using Microsoft.EntityFrameworkCore;
using StardewGroupProject.Data;
using StardewGroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject
{
	public class FarmHelper
	{
		public static void PopulateFarmCmbBox(ComboBox cmbFarmNames)
		{
			cmbFarmNames.DataSource = null; // Temporarily un-binds the ComboBox from the datasource

			cmbFarmNames.Items.Clear();

			var data = ObjectTransferHelper.Context.Farms.Include(farm => farm.Rooms).ThenInclude(room => room.Bundles).ThenInclude(bundle => bundle.Items).ToList(); // Puts all the farms from the database into a list

			cmbFarmNames.DataSource = data; // Re-binds the ComboBox's datasource to the list of items
			cmbFarmNames.DisplayMember = nameof(Farm.Name); // Displays the Name property from the data
		}

		public static void DeleteFarm(Models.Farm farm)
		{
            var roomsToDelete = ObjectTransferHelper.Context.Rooms
                .Where(room => EF.Property<int>(room, "FarmId") == farm.FarmId)
                .ToList();

            foreach (var room in roomsToDelete)
            {
                // Load the bundles associated with the room
                var bundlesToDelete = ObjectTransferHelper.Context.Bundles
                    .Where(bundle => EF.Property<int>(bundle, "RoomId") == room.RoomId)
                    .ToList();

                foreach (var bundle in bundlesToDelete)
                {
                    // Load the items associated with the bundle
                    var itemsToDelete = ObjectTransferHelper.Context.Items
                        .Where(item => EF.Property<int>(item, "BundleId") == bundle.BundleId)
                        .ToList();

                    // Delete each item
                    foreach (var item in itemsToDelete)
                    {
                        ObjectTransferHelper.Context.Items.Remove(item);
                    }

                    // Delete the bundle
                    ObjectTransferHelper.Context.Bundles.Remove(bundle);
                }

                // Delete the room
                ObjectTransferHelper.Context.Rooms.Remove(room);
            }

            // Delete the farm itself
            ObjectTransferHelper.Context.Farms.Remove(farm);

            // Save changes to commit deletions
            ObjectTransferHelper.Context.SaveChanges();
        }

        /// <summary>
        /// This method updates the item's Complete field and 
        /// set in the database.
        /// </summary>
        /// <param name="completionStatus">The value to set the item completion status to.</param>
        /// <param name="item">The Item to be updated.</param>
        public static void UpdateItemComplete(bool completionStatus, Item item)
        {
            item.Complete = completionStatus;
            ObjectTransferHelper.Context.Items.Update(item);
            ObjectTransferHelper.Context.SaveChanges();
        }

        /// <summary>
        /// This method checks if an item is complete or not.
        /// </summary>
        /// <param name="item">The selected item from the bundle</param>
        /// <returns>True if completed. False if not</returns>
        public static bool IsItemComplete(Item item)
        {
            if (item.Complete == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
