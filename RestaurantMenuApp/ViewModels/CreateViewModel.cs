﻿using RestaurantMenuApp.Models;
using RestaurantMenuApp.ModelValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        [MaxLength(150, ErrorMessage = "The Name of the meal should not be longer than 150 characters.")]
        public string Name { get; set; }

        [Required]
        [DessertPriceValidation]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public int Price { get; set; }

        [Required]
        [Display(Name="Meal type")]
        public int MealTypeId { get; set; }

        [Display(Name = "Is vegetarian?")]
        public bool IsVegetarian { get; set; }

        [Required]
        [Display(Name="Ingredients")]
        public int[] ChosenIngredients { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<MealType> MealTypes { get; set; }

        public CreateViewModel()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}
