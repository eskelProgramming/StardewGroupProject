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
    public partial class PantryForm : Form
    {
        public PantryForm()
        {
            InitializeComponent();
        }

        private void PantryForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Pantry").Bundles;

            foreach (Item item in bundles[0].Items)
            {
                cklSpringCrops.Items.Add(item.Name);
            }

            foreach (Item item in bundles[1].Items)
            {
                cklSummerCrops.Items.Add(item.Name);
            }

            foreach (Item item in bundles[2].Items)
            {
                cklFallCrops.Items.Add(item.Name);
            }

            foreach (Item item in bundles[3].Items)
            {
                cklQualityCrops.Items.Add(item.Name);
            }

            foreach (Item item in bundles[4].Items)
            {
                cklAnimal.Items.Add(item.Name);
            }

            foreach (Item item in bundles[5].Items)
            {
                cklArtisan.Items.Add(item.Name);
            }
        }
    }
}
