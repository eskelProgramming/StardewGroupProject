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
    public partial class CraftsRoomForm : Form
    {
        public CraftsRoomForm()
        {
            InitializeComponent();
        }

        private void CraftsRoomForm_Load(object sender, EventArgs e)
        {
            LoadBundles();
        }

        private void LoadBundles()
        {
            // Load bundles into the form
            var bundles = ObjectTransferHelper.CurrentFarm.Rooms[0].Bundles;

            foreach (var item in bundles[0].Items)
            {
                cklSpringForaging.Items.Add(item.Name);
            }

            foreach (var item in bundles[1].Items)
            {
                cklSummerForaging.Items.Add(item.Name);
            }

            foreach (var item in bundles[2].Items)
            {
                cklFallForaging.Items.Add(item.Name);
            }

            foreach (var item in bundles[3].Items)
            {
                cklWinterForaging.Items.Add(item.Name);
            }

            foreach (var item in bundles[4].Items)
            {
                cklConstruction.Items.Add(item.Name);
            }

            foreach (var item in bundles[5].Items)
            {
                cklExoticForaging.Items.Add(item.Name);
            }
        }
    }
}
