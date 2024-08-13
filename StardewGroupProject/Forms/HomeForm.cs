using StardewGroupProject.Data;
using StardewGroupProject.Models;

namespace StardewGroupProject
{
	public partial class HomeForm : Form
	{
		public HomeForm()
		{
			InitializeComponent();
			PopulateFarms();
		}

		private void btnAddNewFarm_Click(object sender, EventArgs e)
		{
			AddNewFarmForm addNewFarm = new();
			addNewFarm.ShowDialog();
		}

		private void btnViewCommunityCenter_Click(object sender, EventArgs e)
		{
			BundlesForm bundles = new BundlesForm();
			this.Hide();
			bundles.FormClosed += (s, args) => this.Show(); // Shows the current form (Home) when the Bundles form is closed
			bundles.ShowDialog();
		}

        private void PopulateFarms()
        {
            FarmContext context = new();

            // Get all the Farms out of the Database
            List<Farm> farms = context.Farms.ToList();

            // Set the DisplayMember property to "Name"
            cmbFarmNames.DisplayMember = "Name";

            // Loop through the Farms and add them to the ComboBox
            foreach (Farm farm in farms)
            {
                cmbFarmNames.Items.Add(farm);
            }
        }

    }
}
