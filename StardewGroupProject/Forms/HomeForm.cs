using Microsoft.EntityFrameworkCore;
using StardewGroupProject.Data;
using StardewGroupProject.Models;
using System.Windows.Forms;

namespace StardewGroupProject
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddNewFarm_Click(object sender, EventArgs e)
        {
            AddNewFarmForm addNewFarm = new();
            addNewFarm.ShowDialog();

            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);
        }

        private void btnViewCommunityCenter_Click(object sender, EventArgs e)
        {
            BundlesForm bundles = new BundlesForm();
            this.Hide();
            bundles.FormClosed += (s, args) => this.Show(); // Shows the current form (Home) when the Bundles form is closed
            bundles.ShowDialog();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);
        }

        private void btnDeleteFarm_Click(object sender, EventArgs e)
        {
            var selectedFarm = cmbFarmNames.SelectedItem as Farm;

            FarmHelper.DeleteFarm(selectedFarm);

            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);
        }
    }
}
