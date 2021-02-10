using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        [Required]
        public int Rank { get; set; }

        [Required]
        public string RestaurantName { get; set; }

        public string? FavDish { get; set; }

        [Required]
        public string Address { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                Rank = 1,
                RestaurantName = "Tucanos",
                FavDish = "Garlic Sirloin",
                Address = "545 E University Pkwy, Orem, UT 84097",
                Phone = "(801) 224-4774",
                Website = "https://www.tucanos.com/"
            };

            Restaurant r2 = new Restaurant
            {
                Rank = 2,
                RestaurantName = "Ruby River Steakhouse",
                FavDish = "Top Sirloin",
                Address = "1454 S University Ave, Provo, UT 84601",
                Phone = "(801) 371-0648",
                Website = "https://www.rubyriver.com/"
            };

            Restaurant r3 = new Restaurant
            {
                Rank = 3,
                RestaurantName = "Station 22",
                FavDish = "Deep Fried Funeral Potatoes",
                Address = "22 W Center St, Provo, UT 84601",
                Phone = "(801) 607-1803",
                Website = "https://www.station22cafe.com/"
            };

            Restaurant r4 = new Restaurant
            {
                Rank = 4,
                RestaurantName = "Sweeto Burrito",
                FavDish = "The Smokehouse",
                Address = "1284 N University Ave, Provo, UT 84604",
                Phone = "801-555-5555",
                Website = "https://sweetoburrito.com/"
            };

            Restaurant r5 = new Restaurant
            {
                Rank = 5,
                RestaurantName = "Two Jacks",
                //FavDish = "Meat Pizza",
                Address = "80 W Center St, Provo, UT 84601",
                Phone = "(801) 377-4747",
                Website = "https://www.twojackspizza.com/"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
