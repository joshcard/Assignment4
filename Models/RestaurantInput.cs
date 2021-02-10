using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class RestaurantInput
    {
        public string Name { get; set; }

        public string RestaurantName { get; set; }

        public string FavoriteDish { get; set; }

        //[DataType(DataType.PhoneNumber, ErrorMessage ="Please input the phone number in the correct format, i.e. (800) 555-5555")]
        //[RegularExpression(string )]
        [Phone]
        public string Phone { get; set; }

        
    }
}
