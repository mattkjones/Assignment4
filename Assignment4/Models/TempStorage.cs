using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TempStorage
    {
        private static List<SuggestedRestaurant> suggestedList = new List<SuggestedRestaurant>();

        public static IEnumerable<SuggestedRestaurant> SuggestedList = suggestedList;

        public static void AddRestaurant(SuggestedRestaurant place)
        {
            suggestedList.Add(place);
        }
    }
}
