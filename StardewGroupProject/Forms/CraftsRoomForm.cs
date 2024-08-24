using Microsoft.EntityFrameworkCore;
using StardewGroupProject.Data;
using StardewGroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewGroupProject
{
    public partial class CraftsRoomForm : Form
    {
        public CraftsRoomForm()
        {
            InitializeComponent();
        }

        private void CraftsRoomForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            // Load bundles into the form
            var bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Crafts Room").Bundles;

            foreach (var item in bundles[0].Items)
            {
                cklSpringForaging.Items.Add(item);
            }

            foreach (var item in bundles[1].Items)
            {
                cklSummerForaging.Items.Add(item);
            }

            foreach (var item in bundles[2].Items)
            {
                cklFallForaging.Items.Add(item);
            }

            foreach (var item in bundles[3].Items)
            {
                cklWinterForaging.Items.Add(item);
            }

            foreach (var item in bundles[4].Items)
            {
                cklConstruction.Items.Add(item);
            }

            foreach (var item in bundles[5].Items)
            {
                cklExoticForaging.Items.Add(item);
            }
        }

        private void cklSpringForaging_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            var item = cklSpringForaging.Items[e.Index];

            var myItem = item as Item;
            if (myItem != null)
            {
                // Update the Complete property based on the checked state
                myItem.Complete = e.NewValue == CheckState.Checked;

                // Save changes to the database using EF Core
                ObjectTransferHelper.Context.Items.Update(myItem);
                ObjectTransferHelper.Context.SaveChanges();
            }
        }
    }
}
