using RestaurantMenuApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.ViewModels
{
    public class CreateSupplyViewModel
    {

        public List<Ingredient> AvailableIngredients { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Quantity must be greater than 0.")]
        public double Quantity { get; set; }

        [Required]
        [Display(Name ="Date of Expiration")]
        public string DateOfExpiration { get; set; }

        [Required]
        [Display(Name = "Ingredient")]
        public int chosenIngredient { get; set; }

    }
}
