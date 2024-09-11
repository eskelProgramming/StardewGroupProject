using StardewGroupProject.Forms;
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
    public partial class RoomsForm : Form
    {
        private Farm farm;

        public RoomsForm()
        {
            InitializeComponent();
        }

        public RoomsForm(Farm farm)
        {
            InitializeComponent();
            this.farm = farm;
        }

        private void btnCraftsRoom_Click(object sender, EventArgs e)
        {
            CraftsRoomForm craftsRoom = new();
            craftsRoom.ShowDialog();
        }

        private void btnPantry_Click(object sender, EventArgs e)
        {
            PantryForm pantry = new();
            pantry.ShowDialog();
        }

        private void btnFishTank_Click(object sender, EventArgs e)
        {
            FishTankForm fishTank = new();
            fishTank.ShowDialog();
        }

        private void btnBoilerRoom_Click(object sender, EventArgs e)
        {
            BoilerRoomForm boilerRoom = new();
            boilerRoom.ShowDialog();
        }

        private void btnBulletinBoard_Click(object sender, EventArgs e)
        {
            BulletinBoardForm bulletinBoard = new();
            bulletinBoard.ShowDialog();
        }

        private void btnVault_Click(object sender, EventArgs e)
        {
            VaultForm vault = new();
            vault.ShowDialog();
        }

        private void btnAbandonedJojomart_Click(object sender, EventArgs e)
        {
            AbandonedJojomartForm abandonedJojomart = new();
            abandonedJojomart.ShowDialog();
        }

        private void btnCraftsRoom_Paint(object sender, PaintEventArgs e)
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

        private void btnPantry_Paint(object sender, PaintEventArgs e)
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

        private void btnFishTank_Paint(object sender, PaintEventArgs e)
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

        private void btnAbandonedJojomart_Paint(object sender, PaintEventArgs e)
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

        private void btnBoilerRoom_Paint(object sender, PaintEventArgs e)
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

        private void btnBulletinBoard_Paint(object sender, PaintEventArgs e)
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

        private void btnVault_Paint(object sender, PaintEventArgs e)
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

        private void btnPantry_MouseEnter(object sender, EventArgs e)
        {
            btnPantry.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnPantry_MouseLeave(object sender, EventArgs e)
        {
            btnPantry.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnFishTank_MouseEnter(object sender, EventArgs e)
        {
            btnFishTank.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnFishTank_MouseLeave(object sender, EventArgs e)
        {
            btnFishTank.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnCraftsRoom_MouseEnter(object sender, EventArgs e)
        {
            btnCraftsRoom.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnCraftsRoom_MouseLeave(object sender, EventArgs e)
        {
            btnCraftsRoom.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnAbandonedJojomart_MouseEnter(object sender, EventArgs e)
        {
            btnAbandonedJojomart.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnAbandonedJojomart_MouseLeave(object sender, EventArgs e)
        {
            btnAbandonedJojomart.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnBoilerRoom_MouseEnter(object sender, EventArgs e)
        {
            btnBoilerRoom.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnBoilerRoom_MouseLeave(object sender, EventArgs e)
        {
            btnBoilerRoom.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnVault_MouseEnter(object sender, EventArgs e)
        {
            btnVault.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnVault_MouseLeave(object sender, EventArgs e)
        {
            btnVault.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnBulletinBoard_MouseEnter(object sender, EventArgs e)
        {
            btnBulletinBoard.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnBulletinBoard_MouseLeave(object sender, EventArgs e)
        {
            btnBulletinBoard.BackColor = Color.FromArgb(255, 215, 137);
        }
    }
}
