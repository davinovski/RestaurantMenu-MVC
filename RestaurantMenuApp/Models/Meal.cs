using RestaurantMenuApp.ModelValidations;
using RestaurantMenuApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.Models
{
        public class Meal
        {
            public static int counter = 0;
            public int Id { get; set; }
            [Required]
            [MaxLength(150,ErrorMessage ="The Name of the meal should not be longer than 150 characters.")]
            public string Name { get; set; }
            [Required]
            [DessertPriceValidation]
            public int Price { get; set; }
            [Required]
            public List<Ingredient> Ingredients { get; set; }

            [Required]
            public int MealTypeId { get; set; }

            public MealType MealType { get; set; }

            public bool IsVegetarian { get; set; }

        public Meal(string name, int price, List<Ingredient> ingredients, int mealTypeId, bool isVegetarian)
        {
            Id = ++counter;
            Name = name;
            Price = price;
            Ingredients = ingredients;
            MealTypeId = mealTypeId;
            IsVegetarian = isVegetarian;
            MealType = DataHolder.MealTypes.Find(mt => mt.Id==mealTypeId);
        }

    }
}
