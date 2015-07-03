using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCModelDemo.Models;

namespace MVCModelDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			var addressRecord = new AddressViewModel
			{
				Id = 5,
				Address = "123 Main St.",
				City = "Rockville",
				State = "MD",
				Zip = "12345"
			};

            return View(addressRecord);
        }

		[HttpPost]
		public ActionResult Save(AddressViewModel addressRecord)
		{
			addressRecord.Save();
			return View("Index");
		}
    }
}