using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AICloudReport.Models.Report
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MobileNo { get; set; }
		public string Email { get; set; }
		public string Company { get; set; }
		public string WorkPhone { get; set; }
		public string CustomerType { get; set; }
		public string HouseNo { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string County { get; set; }
		public string Country { get; set; }
		public string PinCode { get; set; }
		public string CustomerTag1 { get; set; }
		public string CustomerTag2 { get; set; }
		public string Notes { get; set; }
	}
}
