namespace StardewGroupProject
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void btnAddNewFarm_Click(object sender, EventArgs e)
		{
			AddNewFarm addNewFarm = new();
			addNewFarm.ShowDialog();
		}

		private void btnViewCommunityCenter_Click(object sender, EventArgs e)
		{
			Bundles bundles = new Bundles();
			this.Hide();
			bundles.FormClosed += (s, args) => this.Show(); // Shows the current form (Home) when the Bundles form is closed
			bundles.ShowDialog();
		}
	}
}
