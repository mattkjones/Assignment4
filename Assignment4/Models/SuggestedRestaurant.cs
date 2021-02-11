using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VisioForge.Shared.MediaFoundation.OPM;

namespace Assignment4.Models
{
    public class SuggestedRestaurant
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage ="Entered number format is not valid (###-###-####)")]
        public string Phone { get; set; }
    }
}
