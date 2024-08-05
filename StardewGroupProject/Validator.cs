using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StardewGroupProject
{
	public class Validator
	{
		public static bool IsValidFarmName(string farmName)
		{
			if (string.IsNullOrWhiteSpace(farmName))
			{
				return false;
			}

			if (farmName.Length < 1 || farmName.Length > 12)
			{
				return false; 
			}

			return true;
		}
	}
}
