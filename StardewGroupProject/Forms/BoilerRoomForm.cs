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
    public partial class BoilerRoomForm : Form
    {
        public BoilerRoomForm()
        {
            InitializeComponent();
        }

        private void BoilerRoomForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
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
    }
}
