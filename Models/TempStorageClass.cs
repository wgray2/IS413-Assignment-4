using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Assignment_4.Models
{
    public class TempStorageClass
    {
        private static List<RestResponse> restaurants = new List<RestResponse>();

        public static IEnumerable<RestResponse> Restaurants => restaurants;

        public static void AddRestaurant(RestResponse restaurant)
        {
            restaurants.Add(restaurant);
        }
    }
}
