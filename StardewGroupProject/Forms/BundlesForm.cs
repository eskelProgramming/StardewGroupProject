using StardewGroupProject.Forms;
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
		public BundlesForm()
		{
			InitializeComponent();
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
			AbandonedJojomartForm abandonedJojomartForm = new();
			abandonedJojomartForm.ShowDialog();
		}
	}
}
