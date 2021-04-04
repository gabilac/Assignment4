using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestaurantA4.Models;

namespace RestaurantA4.Controllers
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
            //to list restaurants
            List<string> restaurantList = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? phone = r.RestPhone ?? "n/a";
                string? website = r.RestWebsite ?? "Coming Soon";
                string? dish = r.FavDish ?? "It's all tasty!";


                restaurantList.Add($"#{r.RestRank}: {r.RestName} at {r.RestAddress} | Phone: {phone} Website: {website} | Favorite Dish: {dish}");
            };

            return View(restaurantList);
        }

        //suggestions page
        [HttpGet]
        public IActionResult EnterSuggestion()
        {
            return View();
        }

        //collect suggestion
        [HttpPost]
        public IActionResult EnterSuggestion(Suggestion suggestion)
        {
            if (!ModelState.IsValid) //prevents movies from being added if not all fields entered
            {

                return View();
            }
            else
            {
                TempStorage.AddSuggestion(suggestion);
                return View("AllSuggestions", TempStorage.Suggestions);
            }
        }

        //view all suggestions
        [HttpGet("all")]
        public IActionResult AllSuggestions()
        {
            return View(TempStorage.Suggestions);
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
