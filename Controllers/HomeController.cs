using IS413_Assignment_4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Assignment_4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("List")]
        public IActionResult RestList()
        {
            List<string> restList = new List<string>();
            foreach (Restaurant r in Restaurant.GetRestaurants())
            {
                restList.Add($"#{r.RestRanking}: {r.RestName}  -  Best Dish: {r.RestDish}  -  Address: {r.RestAddress}  -  Phone: {r.RestPhone}  -  Link: {r.RestLink}");
            }
            return View(restList);
        }

        [HttpGet]
        public IActionResult AddRestaurant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRestaurant(RestResponse resResponse)
        {
            TempStorageClass.AddRestaurant(resResponse);
            return View();

        }

        public IActionResult UserList()
        {
            return View(TempStorageClass.Restaurants);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
