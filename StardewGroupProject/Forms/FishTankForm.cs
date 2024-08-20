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
    public partial class FishTankForm : Form
    {
        public FishTankForm()
        {
            InitializeComponent();
        }

        private void FishTankForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Fish Tank").Bundles;

            foreach(Item item in bundles[0].Items)
            {
                cklRiverFish.Items.Add(item.Name);
            }

            foreach(Item item in bundles[1].Items)
            {
                cklLakeFish.Items.Add(item.Name);
            }

            foreach(Item item in bundles[2].Items)
            {
                cklOceanFish.Items.Add(item.Name);
            }

            foreach(Item item in bundles[3].Items)
            {
                cklNightFishing.Items.Add(item.Name);
            }

            foreach(Item item in bundles[4].Items)
            {
                cklCrabPot.Items.Add(item.Name);
            }

            foreach(Item item in bundles[5].Items)
            {
                cklSpecialtyFish.Items.Add(item.Name);
            }
        }
    }
}
