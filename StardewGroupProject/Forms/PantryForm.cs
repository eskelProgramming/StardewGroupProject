﻿using StardewGroupProject.Models;
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
    public partial class PantryForm : Form
    {
        public PantryForm()
        {
            InitializeComponent();
        }

        private void PantryForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Pantry").Bundles;

            foreach (Item item in bundles[0].Items)
            {
                cklSpringCrops.Items.Add(item);
            }

            foreach (Item item in bundles[1].Items)
            {
                cklSummerCrops.Items.Add(item);
            }

            foreach (Item item in bundles[2].Items)
            {
                cklFallCrops.Items.Add(item);
            }

            foreach (Item item in bundles[3].Items)
            {
                cklQualityCrops.Items.Add(item);
            }

            foreach (Item item in bundles[4].Items)
            {
                cklAnimal.Items.Add(item);
            }

            foreach (Item item in bundles[5].Items)
            {
                cklArtisan.Items.Add(item);
            }
        }

        private void cklSpringCrops_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklSpringCrops.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklSummerCrops_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklSummerCrops.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklFallCrops_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklFallCrops.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklQualityCrops_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklQualityCrops.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklAnimal_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklAnimal.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklArtisan_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklArtisan.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }
    }
}
