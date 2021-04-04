using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RestaurantA4.Models
{
    public class Restaurant
    {
        //required
        [ReadOnly(true)]
        public int RestRank { get; set;}
        public string RestName { get; set; }
        public string RestAddress { get; set; }

        //optional
        public string? RestPhone { get; set; }
        public string? RestWebsite { get; set; }
        public string? FavDish { get; set; }


        public static Restaurant[] GetRestaurants()
        {

            //labeled and named in order of rankings
            Restaurant r1 = new Restaurant
            {
                RestRank = 1,
                RestName = "Koko Lunchbox",
                RestAddress = "1175 N Canyon Rd",
                RestPhone = "801-850-4358",
                FavDish = "Tonkotsu Ramen"
            };

            Restaurant r2 = new Restaurant
            {
                RestRank = 2,
                RestName = "Bombay House - Provo",
                RestAddress = "463 N University Ave",
                RestPhone = "801-373-6677",
                RestWebsite = "bombayhouse.com",
                FavDish = "Chicken Tikka Masala"
            };

            Restaurant r3 = new Restaurant
            {
                RestRank = 3,
                RestName = "Five Sushi Brothers",
                RestAddress = "445 N Freedom Blvd",
                RestPhone = "801-228-1636",
                RestWebsite = "fivesushibrothers.com"
            };

            Restaurant r4 = new Restaurant
            {
                RestRank = 4,
                RestName = "Waffle Love",
                RestAddress = "1831 N State St",
                RestPhone = "801-228-1636",
                RestWebsite = "waffluv.com",
                FavDish = "Red Wonder"
            };

            Restaurant r5 = new Restaurant
            {
                RestRank = 5,
                RestName = "Spicy Thai",
                RestAddress = "3230 N University Ave",
                RestPhone = "801-370-0707",
                RestWebsite = "spicythaiprovo.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
