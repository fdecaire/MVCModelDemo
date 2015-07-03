using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCModelDemo.Models
{
	public class AddressViewModel
	{
		public int Id { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }

		public void Save()
		{
			// save this record
		}
	}
}