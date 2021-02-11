using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TopRestaurants
    {
        public TopRestaurants(int rank)
        {
             Rank = rank;
        }
        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        [Required]
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Link { get; set; }


        public static TopRestaurants[] GetRestaurants()
        {
            TopRestaurants r1 = new TopRestaurants(1)
            {
                RestaurantName = "180 Tacos",
                FavoriteDish = "Buffalo Chicken Salad",
                Address = "3368 N University Ave, Provo, UT 84604",
                Phone = "801-356-8226",
                Link = "https://www.180tacos.com/"
            };

            TopRestaurants r2 = new TopRestaurants(2)
            {
                RestaurantName = "Asa Ramen",
                FavoriteDish = "Tonkotsu Ramen",
                Address = "1120 S State St, Orem, UT 84097",
                Phone = "801-842-1898"
            };

            TopRestaurants r3 = new TopRestaurants(3)
            {
                RestaurantName = "Slab Pizza",
                FavoriteDish = "Buffalo Wing Pizza",
                Address = "671 E 800 N, Provo, UT 84606",
                Phone = "801-377-3883",
                Link = "https://www.slabpizza.com/",
            };

            TopRestaurants r4 = new TopRestaurants(4)
            {
                RestaurantName = "Cupbop",
                Address = "815 700 E, Provo, UT 84606",
                Phone = "801-916-8968",
                Link = "https://cupbop.com/"
            };

            TopRestaurants r5 = new TopRestaurants(5)
            {
                RestaurantName = "Cubby's",
                FavoriteDish = "Dragonslayer Burger",
                Address = "1258 N State St, Provo, UT 84604",
                Phone = "801-919-3023",
                Link = "https://cubbys.co/"
            };

            return new TopRestaurants[] { r1, r2, r3, r4, r5 };
        }

    }
}
