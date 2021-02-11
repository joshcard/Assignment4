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

        //Action for index page
        public IActionResult Index()
        {
            //Uses the array of by calling the GetRestaurants method and saves it all into a string to be displayed like shown in the videos.
            List<string> top5Restaurants = new List<string>();

            foreach(Restaurant r in Restaurant.GetRestaurants())
            {
                string? favDish = r.FavDish ?? "It's all tasty!";

                top5Restaurants.Add($"#{r.Rank}: {r.RestaurantName}, Favorite Dish: {favDish}, Address: {r.Address}, " +
                    $"Phone: {r.Phone}, Website: {r.Website}");

            }

            return View(top5Restaurants);
        }

        //HttpGet forthe RestaurantInput view
        [HttpGet]
        public IActionResult RestaurantInput()
        {
            return View();
        }

        //HttpPost tied to the form on the RestaurantInput view
        [HttpPost]
        public IActionResult RestaurantInput(RestaurantInput restaurantInput)
        {
            //verifies that the form has been filled correctly
            if (ModelState.IsValid)
            {
                TempStorage.AddRestaurant(restaurantInput);
                //if fav dish is null then display its all tasty
                foreach (RestaurantInput ri in TempStorage.restaurantInputs)
                {
                    if (ri.FavoriteDish == null | ri.FavoriteDish == "")
                    {
                        ri.FavoriteDish = "It's all tasty!";
                    }
                }
                //if correct then it displays the inputted restaurants
                return View("RestaurantList", TempStorage.restaurantInputs);
            }
            else
            {
                //if not filled correctly then it will stay on the RestaurantInput page and display the error (incorrect phone format)
                return View();
            }
        }

        //Action to display the RestaurantList view
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
