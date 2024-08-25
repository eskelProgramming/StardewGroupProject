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
    public partial class FishTankForm : Form
    {
        public FishTankForm()
        {
            InitializeComponent();
        }

        private void FishTankForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Fish Tank").Bundles;

            foreach (Item item in bundles[0].Items)
            {
                cklRiverFish.Items.Add(item);
            }

            foreach (Item item in bundles[1].Items)
            {
                cklLakeFish.Items.Add(item);
            }

            foreach (Item item in bundles[2].Items)
            {
                cklOceanFish.Items.Add(item);
            }

            foreach (Item item in bundles[3].Items)
            {
                cklNightFishing.Items.Add(item);
            }

            foreach (Item item in bundles[4].Items)
            {
                cklCrabPot.Items.Add(item);
            }

            foreach (Item item in bundles[5].Items)
            {
                cklSpecialtyFish.Items.Add(item);
            }
        }

        private void cklCrabPot_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklCrabPot.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklLakeFish_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklLakeFish.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklNightFishing_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklNightFishing.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklOceanFish_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklOceanFish.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklRiverFish_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklRiverFish.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklSpecialtyFish_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklSpecialtyFish.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }
    }
}
