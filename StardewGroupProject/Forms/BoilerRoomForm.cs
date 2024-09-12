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
    public partial class BoilerRoomForm : Form
    {
        public BoilerRoomForm()
        {
            InitializeComponent();
        }

        private void BoilerRoomForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
            UpdateCheckboxes();
        }

        private void UpdateCheckboxes()
        {
            for (int i = 0; i < cklBlacksmiths.Items.Count; i++)
            {
                cklBlacksmiths.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklBlacksmiths.Items[i]));
            }

            for (int i = 0; i < cklGeologists.Items.Count; i++)
            {
                cklGeologists.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklGeologists.Items[i]));
            }

            for (int i = 0; i < cklAdventurers.Items.Count; i++)
            {
                cklAdventurers.SetItemChecked(i, FarmHelper.IsItemComplete((Item)cklAdventurers.Items[i]));
            }
        }

        private void LoadBundles()
        {
            List<Bundle> boilerRoomBundles = ObjectTransferHelper.CurrentFarm.GetRoom("Boiler Room").Bundles;

            foreach (var item in boilerRoomBundles[0].Items)
            {
                cklBlacksmiths.Items.Add(item);
            }

            foreach (var item in boilerRoomBundles[1].Items)
            {
                cklGeologists.Items.Add(item);
            }

            foreach (var item in boilerRoomBundles[2].Items)
            {
                cklAdventurers.Items.Add(item);
            }
        }

        private void cklBlacksmiths_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklBlacksmiths.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklGeologists_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklGeologists.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void cklAdventurers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that was clicked
            Item item = (Item)cklAdventurers.Items[e.Index];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(e.NewValue == CheckState.Checked, item);
            }
        }

        private void lblBlacksmiths_Paint(object sender, PaintEventArgs e)
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

        private void lblAdventurers_Paint(object sender, PaintEventArgs e)
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

        private void lblGeologists_Paint(object sender, PaintEventArgs e)
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
    }
}
