using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using System.Diagnostics;

namespace MyWebsite.Controllers
{
	public class HomeController : Controller
	{
	
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Contact() 
		{
			var contacts = new Dictionary<string, string>
			{
				{ "Phone", "314-286-3675"},
				{ "Email", "LouDiamond_Loyloy@insideranken.org"},
				{ "Facebook", "Facebook.com/mywebsite"}
			};
			return View(contacts);
		}

		
	}
}