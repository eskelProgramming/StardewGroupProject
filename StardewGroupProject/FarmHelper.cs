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
			FarmContext farmContext = new();

			cmbFarmNames.DataSource = null; // Temporarily un-binds the ComboBox from the datasource

			cmbFarmNames.Items.Clear();

			var data = farmContext.Farms.ToList(); // Puts all the farms from the database into a list

			cmbFarmNames.DataSource = data; // Re-binds the ComboBox's datasource to the list of items
			cmbFarmNames.DisplayMember = "Name"; // Displays the Name property from the data
		}

		public static void DeleteFarm(Models.Farm farm)
		{
			FarmContext farmContext = new();

            var roomsToDelete = farmContext.Rooms
                .Where(room => EF.Property<int>(room, "FarmId") == farm.FarmId)
                .ToList();

            foreach (var room in roomsToDelete)
            {
                // Load the bundles associated with the room
                var bundlesToDelete = farmContext.Bundles
                    .Where(bundle => EF.Property<int>(bundle, "RoomId") == room.RoomId)
                    .ToList();

                foreach (var bundle in bundlesToDelete)
                {
                    // Load the items associated with the bundle
                    var itemsToDelete = farmContext.Items
                        .Where(item => EF.Property<int>(item, "BundleId") == bundle.BundleId)
                        .ToList();

                    // Delete each item
                    foreach (var item in itemsToDelete)
                    {
                        farmContext.Items.Remove(item);
                    }

                    // Delete the bundle
                    farmContext.Bundles.Remove(bundle);
                }

                // Delete the room
                farmContext.Rooms.Remove(room);
            }

            // Delete the farm itself
            farmContext.Farms.Remove(farm);

            // Save changes to commit deletions
            farmContext.SaveChanges();
        }
    }
}
