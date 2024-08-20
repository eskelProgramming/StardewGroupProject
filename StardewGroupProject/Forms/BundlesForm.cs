using StardewGroupProject.Forms;
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
	public partial class BundlesForm : Form
	{
		private Farm farm;

		public BundlesForm()
		{
			InitializeComponent();
		}

        public BundlesForm(Farm farm)
        {
            InitializeComponent();
			this.farm = farm;
        }

        private void btnCraftsRoom_Click(object sender, EventArgs e)
        {
            //CraftsRoomForm craftsRoom = new();
            //craftsRoom.ShowDialog();

            RoomSelect room = new("Crafts Room");
            room.ShowDialog();
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
    }
}
