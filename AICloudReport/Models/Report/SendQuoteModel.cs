using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AICloudReport.Models.Report
{
	public class SendQuote
	{
		public string Name { get; set; }
		public string TotalAmount { get; set; }
		public string Status { get; set; }
		public DateTime AssignmentDate { get; set; }
		public string Notes { get; set; }
		public int Customer_Id { get; set; }
		public int Employee_Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public List<ServicesModel> Services { get; set; }
		public List<MaterialsModel> Materials { get; set; }
		public List<string> JobTags { get; set; }
		public string JobNotes { get; set; }
		public List<string> JobPhoto { get; set; }
	}
}
