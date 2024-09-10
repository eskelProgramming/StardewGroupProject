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

namespace StardewGroupProject.Forms
{
    public partial class CustomMessageBoxForm : Form
    {
        public CustomMessageBoxForm()
        {
            InitializeComponent();
        }

        public void InvalidFarmNameMessage()
        {
            grpCustomMessageBox.Text = "Invalid Farm Name!";

            txtCustomMessageBox.Text = "Farm name must be between 1-12 characters.";

            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUnderstood.Visible = true;
        }

        public void ValidFarmNameMessage()
        {
            grpCustomMessageBox.Text = "Success!";

            txtCustomMessageBox.Text = "Farm successfully added.";

            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUnderstood.Visible = true;
        }

        public void NoFarmSelectedMessage()
        {
            grpCustomMessageBox.Text = "No Farm Selected!";

            txtCustomMessageBox.Text = "Please select, or create a farm to continue.";

            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUnderstood.Visible = true;
        }

        public void DeleteFarmConfirmationMessage()
        {
            grpCustomMessageBox.Text = "Delete Farm?";

            txtCustomMessageBox.Text = $"Are you sure you want to delete {ObjectTransferHelper.CurrentFarm.Name} ?";

            btnYes.Visible = true;
            btnNo.Visible = true;
            btnUnderstood.Visible = false;
        }

        public void DeleteFarmSuccessMessage()
        {
            grpCustomMessageBox.Text = "Success!";

            txtCustomMessageBox.Text = $"{ObjectTransferHelper.CurrentFarm.Name} has been deleted.";

            btnYes.Visible = false;
            btnNo.Visible = false;
            btnUnderstood.Visible = true;
        }


        private void grpCustomMessageBox_Paint(object sender, PaintEventArgs e)
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
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnUnderstood_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius - 1, btn.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the button's region to the rounded rectangle
                btn.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnYes_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius - 1, btn.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the button's region to the rounded rectangle
                btn.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnNo_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;

            if (btn != null)
            {
                // Define the color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius - 1, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius - 1, btn.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius - 1, radius, radius, 90, 90);
                path.CloseAllFigures();

                // Set the button's region to the rounded rectangle
                btn.Region = new Region(path);

                // Draw the custom border
                Pen pen = new Pen(woodBrown, 8);
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            btnYes.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
            btnNo.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnUnderstood_MouseEnter(object sender, EventArgs e)
        {
            btnUnderstood.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnUnderstood_MouseLeave(object sender, EventArgs e)
        {
            btnUnderstood.BackColor = Color.FromArgb(255, 215, 137);
        }




        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
        private void btnUnderstood_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
