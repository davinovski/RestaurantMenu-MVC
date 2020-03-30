using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.Models
{
    public class Supply
    {
        [Required]
        public Ingredient Ingredient { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public double Quantity { get; set; }

        [Required]
        [Display(Name="Date of Expiration")]
        public string DateOfExpiration { get; set; }

        public Supply()
        {
            Ingredient = new Ingredient();
        }

        public Supply(Ingredient ingredient, double quantity, string dateOfExpiration)
        {
            Ingredient = ingredient;
            Quantity = quantity;
            DateOfExpiration = dateOfExpiration;
        }
    }
}
