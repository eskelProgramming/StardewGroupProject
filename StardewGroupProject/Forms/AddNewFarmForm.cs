using StardewGroupProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StardewGroupProject.Data;

namespace StardewGroupProject
{
	public partial class AddNewFarmForm : Form
	{
		public AddNewFarmForm()
		{
			InitializeComponent();
		}

		private void btnNewFarmCreate_Click(object sender, EventArgs e)
		{
			string newFarmName = txtNewFarmName.Text;

			if (Validator.IsValidFarmName(newFarmName)) // Checks if the farm name is valid using the Validator class
			{
				Farm farm = new(newFarmName);

				ObjectTransferHelper.Context.Farms.Add(farm); // Adds the new Farm object to the Database using Entity Framework
                ObjectTransferHelper.Context.SaveChanges(); // Saves those changes

				MessageBox.Show("Farm successfully added!");
				Close();
			}
			else
			{
				MessageBox.Show("Invalid Farm Name. Must not be empty, and be between 1-12 characters.", "Warning!",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);

				txtNewFarmName.Clear();
			}
		}

		private void btnNewFarmCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
