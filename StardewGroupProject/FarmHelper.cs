using StardewGroupProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject
{
	public class FarmHelper
	{
		public static void PopulateFarmCmbBox(ComboBox cmbFarmNames)
		{
			FarmContext farmContext = new();

			cmbFarmNames.DataSource = null; // Temporarily un-binds the ComboBox from the datasource

			cmbFarmNames.Items.Clear();

			var data = farmContext.Farms.ToList(); // Puts all the farms from the database into a list

			cmbFarmNames.DataSource = data; // Re-binds the ComboBox's datasource to the list of items
			cmbFarmNames.DisplayMember = "Name"; // Displays the Name property from the data
		}
	}
}
