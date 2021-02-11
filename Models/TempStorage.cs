using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //TempStorage class used to save the inputted restaurant info during the session
    public class TempStorage
    {
        private static List<RestaurantInput> restInput = new List<RestaurantInput>();

        public static IEnumerable<RestaurantInput> restaurantInputs => restInput;

        public static void AddRestaurant(RestaurantInput restaurantInput)
        {
            restInput.Add(restaurantInput);
        }
    }
}
