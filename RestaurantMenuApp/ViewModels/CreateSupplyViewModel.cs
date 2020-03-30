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
        [RegularExpression(@"((0[13578]|1[02])-(0[1-9]|[12]\d|3[01])-[12]\d{3})|((02)-(0[1-9]|1[1-9]|2[1-8])-[12]\d{3})|((0[469]|11)-(0[1-9]|[12]\d|30)-[12]\d{3})", ErrorMessage ="Date should be in format MM-dd-YYYY")]
        public string DateOfExpiration { get; set; }

        [Required]
        [Display(Name = "Ingredient")]
        public int chosenIngredient { get; set; }

    }
}
