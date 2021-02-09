using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Assignment_4.Models
{
    public class Restaurant
    {
        [Required]
        public int RestRanking { get; set; }
        [Required]
        public string RestName { get; set; }
        public string? RestDish { get; set; } = "It’s all tasty!";
        [Required]
        public string RestAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? RestPhone { get; set; } = "NA";
        public string? RestLink { get; set; } = "Coming soon.";



        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                RestRanking = 1,
                RestName = "Betos",
                RestDish = "Carne Asada Fries",
                RestAddress = "123 State St",
                RestPhone = "(801)-123-1111",
                RestLink = "www.betos.com",
            };
            Restaurant r2 = new Restaurant
            {
                RestRanking = 2,
                RestName = "L&L",
                RestDish = "Chicken Katsu",
                RestAddress = "123 Cougar Blvd",
                RestPhone = "(801)-123-2222",
                RestLink = "www.LL.com",
            };
            Restaurant r3 = new Restaurant
            {
                RestRanking = 3,
                RestName = "Black Sheep",
                RestDish = "Chime Relleno",
                RestAddress = "123 University Ave",
                RestPhone = "(801)-123-3333",
                RestLink = "www.blacksheep.com",
            };
            Restaurant r4 = new Restaurant
            {
                RestRanking = 4,
                RestName = "Chom",
                RestDish = "Bacon Cheeseburger",
                RestAddress = "123 S 300 W",
                RestPhone = "(801)-123-4444",
                RestLink = "www.chom.com",
            };
            Restaurant r5 = new Restaurant
            {
                RestRanking = 5,
                RestName = "McDonalds",
                RestDish = "Big Mac",
                RestAddress = "1234 Cougar Blvd",
                RestPhone = "(801)-123-5555",
                RestLink = "www.mcdonalds.com",
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
