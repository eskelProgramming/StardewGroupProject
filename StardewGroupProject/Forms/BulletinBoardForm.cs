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
    public partial class BulletinBoardForm : Form
    {
        public BulletinBoardForm()
        {
            InitializeComponent();
        }

        private void BulletinBoardForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            List<Bundle> bundles = ObjectTransferHelper.CurrentFarm.GetRoom("Bulletin Board").Bundles;

            foreach (var item in bundles[0].Items)
            {
                cklChefs.Items.Add(item.Name);
            }

            foreach (var item in bundles[1].Items)
            {
                cklDye.Items.Add(item.Name);
            }

            foreach (var item in bundles[2].Items)
            {
                cklFieldResearch.Items.Add(item.Name);
            }

            foreach (var item in bundles[3].Items)
            {
                cklFodder.Items.Add(item.Name);
            }

            foreach (var item in bundles[4].Items)
            {
                cklEnchanters.Items.Add(item.Name);
            }
        }
    }
}
