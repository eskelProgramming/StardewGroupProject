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
		}

		private void btnViewCommunityCenter_Click(object sender, EventArgs e)
		{
			BundlesForm bundles = new BundlesForm();
			this.Hide();
			bundles.FormClosed += (s, args) => this.Show(); // Shows the current form (Home) when the Bundles form is closed
			bundles.ShowDialog();
		}
	}
}
