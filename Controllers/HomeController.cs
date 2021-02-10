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
            List<string> top5Restaurants = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? favDish = r.FavDish ?? "It's all tasty!";

                top5Restaurants.Add($"#{r.Rank}: {r.RestaurantName}, Favorite Dish: {favDish}, Address: {r.Address}, Phone: {r.Phone}, Website: {r.Website}");

                //top5Restaurants.Add("#" + r.Rank + ": " + r.RestaurantName + "\r\n" + "Favorite Dish: " + favDish + "\r\n" + "Address: " + r.Address + "\r\n" +
                //                    "Phone: " + r.Phone + "\r\n" + "Website: " + r.Website);

            }

            return View(top5Restaurants);
        }

        [HttpGet]
        public IActionResult RestaurantInput()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RestaurantInput(RestaurantInput restaurantInput)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurantInput);
                return View("RestaurantList", TempStorage.restaurantInputs);
            }
            else
            {
                return View();
            }
        }

        public IActionResult RestaurantList()
        {
            return View(TempStorage.restaurantInputs);
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
