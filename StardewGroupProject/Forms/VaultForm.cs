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
	public partial class VaultForm : Form
	{
		public VaultForm()
		{
			InitializeComponent();
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
	}
}
