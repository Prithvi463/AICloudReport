using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AICloudReport.Models.Report
{
	public class MaterialsModel
	{
		public string Material { get; set; }
		public string Name { get; set; }
		public int Quantity { get; set; }
		public string Description { get; set; }
		public string Amount { get; set; }
		public string UnitPrice { get; set; }
		public string Discount { get; set; }
	}
}
