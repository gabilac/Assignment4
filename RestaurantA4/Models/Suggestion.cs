using System;
using System.ComponentModel.DataAnnotations; //allow validation

namespace RestaurantA4.Models
{
    //allows user to suggest new restaurant
    public class Suggestion
    {
        public string Name { get; set; }
        public string RestName { get; set; }
        public string FavDish { get; set; }
        //phone format validation
        [DataType (DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})[-. ]?([0-9]{3})[-.]?([0-9]{4})$", ErrorMessage = "Phone Number must be in the format ###-###-####")]
        public string Phone { get; set; }
    }
}
