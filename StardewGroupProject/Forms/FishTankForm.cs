using StardewGroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            UpdateCheckboxes();
        }

        private void UpdateCheckboxes()
        {
            for (int i = 0; i < cklRiverFish.Items.Count; i++)
            {
                cklRiverFish.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklRiverFish.Items[i]));
            }

            for (int i = 0; i < cklLakeFish.Items.Count; i++)
            {
                cklLakeFish.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklLakeFish.Items[i]));
            }

            for (int i = 0; i < cklOceanFish.Items.Count; i++)
            {
                cklOceanFish.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklOceanFish.Items[i]));
            }

            for (int i = 0; i < cklNightFishing.Items.Count; i++)
            {
                cklNightFishing.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklNightFishing.Items[i]));
            }

            for (int i = 0; i < cklCrabPot.Items.Count; i++)
            {
                cklCrabPot.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklCrabPot.Items[i]));
            }

            for (int i = 0; i < cklSpecialtyFish.Items.Count; i++)
            {
                cklSpecialtyFish.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklSpecialtyFish.Items[i]));
            }
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

        private void lblSpecialtyFish_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void lblOceanFish_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void lblRiverFish_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void lblCrabPot_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void lblNightFishing_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void lblLakeFish_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            if (lbl != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(lbl.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(lbl.Width - radius - 1, lbl.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, lbl.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the label's region to the rounded rectangle
                lbl.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 4);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void cklOceanFish_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
