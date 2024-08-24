using Microsoft.EntityFrameworkCore;
using StardewGroupProject.Data;
using StardewGroupProject.Models;
using System.Windows.Forms;

namespace StardewGroupProject
{
    public partial class HomeForm : Form
    {
        private Farm farm;
        
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnAddNewFarm_Click(object sender, EventArgs e)
        {
            AddNewFarmForm addNewFarm = new();
            addNewFarm.ShowDialog();

            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);
            SetCurrentFarm();
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
            SetCurrentFarm();
        }

        private void btnDeleteFarm_Click(object sender, EventArgs e)
        {
            if (cmbFarmNames.SelectedIndex == -1)
            {
                MessageBox.Show("Must select a Farm, or add a new Farm!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {cmbFarmNames.Text}?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FarmHelper.DeleteFarm(ObjectTransferHelper.CurrentFarm);

                    MessageBox.Show($"{cmbFarmNames.Text} successfully deleted!", "Success");
                }

            }

            FarmHelper.PopulateFarmCmbBox(cmbFarmNames);

            SetCurrentFarm();
        }

        private void cmbFarmNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCurrentFarm();
        }

        /// <summary>
        /// Gets the currently selected Farm and sets it as the current Farm in the ObjectTransferHelper class.
        /// </summary>
        private void SetCurrentFarm()
        {
            Farm? currFarm = cmbFarmNames.SelectedItem as Farm;
            if (currFarm != null)
            {
                ObjectTransferHelper.CurrentFarm = ObjectTransferHelper.Context.Farms.FirstOrDefault(f => f.FarmId == currFarm.FarmId);

                if (ObjectTransferHelper.CurrentFarm != null)
                {
                    ObjectTransferHelper.CurrentFarm.Rooms = ObjectTransferHelper.Context.Rooms
                        .Include(r => r.Bundles)
                        .ThenInclude(b => b.Items)
                        .ToList();

                    ObjectTransferHelper.CurrentFarm.Rooms.ForEach(r => r.Bundles.ForEach(b => b.Items.ForEach(i => i = ObjectTransferHelper.Context.Items.FirstOrDefault(it => it.ItemId == i.ItemId))));
                }
            }
        }
    }
}
