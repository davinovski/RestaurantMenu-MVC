using RestaurantMenuApp.Models;
using RestaurantMenuApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.ModelValidations
{
    public class DessertPriceValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var meal = (CreateViewModel)validationContext.ObjectInstance;

            if (meal.MealTypeId == 2 && meal.Price<200)
                return new ValidationResult("The price for a dessert should be bigger than 200 MKD.");

            return ValidationResult.Success;
        }
    }
}
