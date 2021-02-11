using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    //class for the RestaurantInput
    public class RestaurantInput
    {
        public string Name { get; set; }

        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; }

        //Verify that the phone number was entered correctly
        [RegularExpression(@"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}", ErrorMessage = "Entered phone format is not valid. Must be XXX-XXX-XXXX.")]
        public string Phone { get; set; }

        
    }
}
