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
                cklBlacksmiths.Items.Add(item.Name);
            }

            foreach (var item in boilerRoomBundles[1].Items)
            {
                cklGeologists.Items.Add(item.Name);
            }

            foreach (var item in boilerRoomBundles[2].Items)
            {
                cklAdventurers.Items.Add(item.Name);
            }
        }
    }
}
