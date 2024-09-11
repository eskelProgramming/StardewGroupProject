using Microsoft.EntityFrameworkCore;
using StardewGroupProject.Data;
using StardewGroupProject.Forms;
using StardewGroupProject.Models;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StardewGroupProject
{
    public partial class HomeForm : Form
    {
        private Farm farm;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddNewFarm_Click(object sender, EventArgs e)
        {
            AddNewFarmForm addNewFarm = new();
            addNewFarm.ShowDialog();

            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);
            SetCurrentFarm();
        }

        private void btnViewCommunityCenter_Click(object sender, EventArgs e)
        {
            if (cmbFarmNames.SelectedIndex == -1)
            {
                CustomMessageBoxForm messageBox = new();

                messageBox.NoFarmSelectedMessage();

                messageBox.ShowDialog();
            }
            else
            {
                RoomsForm rooms = new RoomsForm();
                this.Hide();
                rooms.FormClosed += (s, args) => this.Show(); // Shows the current form (Home) when the Rooms form is closed
                rooms.ShowDialog();
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);
            SetCurrentFarm();
        }

        private void btnDeleteFarm_Click(object sender, EventArgs e)
        {
            if (cmbFarmNames.SelectedIndex == -1)
            {
                CustomMessageBoxForm messageBox = new();

                messageBox.NoFarmSelectedMessage();

                messageBox.ShowDialog();
            }
            else
            {
                CustomMessageBoxForm messageBox = new();

                messageBox.DeleteFarmConfirmationMessage();

                DialogResult result = messageBox.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    FarmHelper.DeleteFarm(ObjectTransferHelper.CurrentFarm);

                    CustomMessageBoxForm messageBoxSuccess = new();

                    messageBoxSuccess.DeleteFarmSuccessMessage();

                    messageBoxSuccess.ShowDialog();
                }

            }

            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);

            SetCurrentFarm();
        }

        private void cmbFarmNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCurrentFarm();
        }

        /// <summary>
        /// Gets the currently selected Farm and sets it as the current Farm in the ObjectTransferHelper class.
        /// </summary>
        private void SetCurrentFarm()
        {
            Farm? currFarm = cmbFarmNames.SelectedItem as Farm;
            if (currFarm != null)
            {
                ObjectTransferHelper.CurrentFarm = ObjectTransferHelper.Context.Farms.Include(farm => farm.Rooms)
                                                                                    .ThenInclude(room => room.Bundles)
                                                                                    .ThenInclude(bundle => bundle.Items)
                                                                                    .FirstOrDefault(f => f.FarmId == currFarm.FarmId);
            }
        }



        // Below are the custom paint methods for the buttons and labels

        private void btnViewCommunityCenter_Paint(object sender, PaintEventArgs e)
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

        private void btnDeleteFarm_Paint(object sender, PaintEventArgs e)
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

        private void btnAddNewFarm_Paint(object sender, PaintEventArgs e)
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

        private void lblChooseFarm_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;
            if (lbl != null)
            {
                // Define wood brown color
                Color woodBrown = Color.FromArgb(226, 122, 62);

                // Create a rounded rectangle path
                int radius = 10; // Adjust the radius for more or less rounding
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

        private void lblWelcomeMessage_Paint(object sender, PaintEventArgs e)
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

        private void cmbFarmNames_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ComboBox
            e.DrawBackground();

            Color woodBrown = Color.FromArgb(226, 122, 62);

            // Draw the border
            using (Pen borderPen = new Pen(woodBrown, 5))
            {
                e.Graphics.DrawRectangle(borderPen, e.Bounds);
            }

            // Draw the text
            if (e.Index >= 0)
            {
                string farmName = ((Farm)cmbFarmNames.Items[e.Index]).Name;
                e.Graphics.DrawString(farmName, e.Font, Brushes.Black, e.Bounds);
            }

            // Draw the focus rectangle
            e.DrawFocusRectangle();
        }

        private void btnAddNewFarm_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewFarm.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnAddNewFarm_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewFarm.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnViewCommunityCenter_MouseEnter(object sender, EventArgs e)
        {
            btnViewCommunityCenter.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnViewCommunityCenter_MouseLeave(object sender, EventArgs e)
        {
            btnViewCommunityCenter.BackColor = Color.FromArgb(255, 215, 137);
        }

        private void btnDeleteFarm_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteFarm.BackColor = Color.FromArgb(214, 180, 116);
        }

        private void btnDeleteFarm_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteFarm.BackColor = Color.FromArgb(255, 215, 137);
        }
    }
}
