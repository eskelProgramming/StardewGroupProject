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
    }
}
