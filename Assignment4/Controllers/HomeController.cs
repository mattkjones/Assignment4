using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Controllers
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
            List<string> restaurantList = new List<string>();

            foreach(TopRestaurants r in TopRestaurants.GetRestaurants())
            {
                string dish = r.FavoriteDish ?? "It's all tasty!";
                string site = r.Link ?? "Coming soon";

                restaurantList.Add("#" + r.Rank + ": " + r.RestaurantName +
                    " Favorite Dish: " + dish + " Address: " + r.Address
                     + " Phone: " + r.Phone + " Link: " + site);
            }

            return View(restaurantList);
        }

        [HttpGet]
        public IActionResult Suggestions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestions(SuggestedRestaurant addRestaurant)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(addRestaurant);
                return View("SuggestionsList", TempStorage.SuggestedList);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SuggestionsList()
        {
            return View(TempStorage.SuggestedList);
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
