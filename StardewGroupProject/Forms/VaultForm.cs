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
    public partial class VaultForm : Form
    {
        public VaultForm()
        {
            InitializeComponent();
        }

        private void VaultForm_Load(object sender, EventArgs e)
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.Rooms[4].Bundles;
            if (bundles[0].Items[0].Complete)
            {
                chkVault2500.Checked = true;
            }

            if (bundles[1].Items[0].Complete)
            {
                chkVault5000.Checked = true;
            }

            if (bundles[2].Items[0].Complete)
            {
                chkVault10000.Checked = true;
            }

            if (bundles[3].Items[0].Complete)
            {
                chkVault25000.Checked = true;
            }
        }

        private void chkVault2500_CheckedChanged(object sender, EventArgs e)
        {
            // Get the item that was clicked
            Item item = ObjectTransferHelper.CurrentFarm.Rooms[4].Bundles[0].Items[0];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(chkVault2500.Checked, item);
            }
        }

        private void chkVault5000_CheckedChanged(object sender, EventArgs e)
        {
            // Get the item that was clicked
            Item item = ObjectTransferHelper.CurrentFarm.Rooms[4].Bundles[1].Items[0];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(chkVault5000.Checked, item);
            }
        }

        private void chkVault10000_CheckedChanged(object sender, EventArgs e)
        {
            // Get the item that was clicked
            Item item = ObjectTransferHelper.CurrentFarm.Rooms[4].Bundles[2].Items[0];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(chkVault10000.Checked, item);
            }
        }

        private void chkVault25000_CheckedChanged(object sender, EventArgs e)
        {
            // Get the item that was clicked
            Item item = ObjectTransferHelper.CurrentFarm.Rooms[4].Bundles[3].Items[0];
            if (item != null)
            {
                FarmHelper.UpdateItemComplete(chkVault25000.Checked, item);
            }
        }

        private void gb2500g_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            if (box != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(box.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(box.Width - radius - 1, box.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, box.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the GroupBox's region to the rounded rectangle
                box.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 6);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void gb5000g_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            if (box != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(box.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(box.Width - radius - 1, box.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, box.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the GroupBox's region to the rounded rectangle
                box.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 6);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void gb10000g_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            if (box != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(box.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(box.Width - radius - 1, box.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, box.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the GroupBox's region to the rounded rectangle
                box.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 6);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void gb25000g_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            if (box != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(box.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(box.Width - radius - 1, box.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, box.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the GroupBox's region to the rounded rectangle
                box.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 6);
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
