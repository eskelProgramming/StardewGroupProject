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
	}
}
