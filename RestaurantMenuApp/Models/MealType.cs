using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.Models
{
    public enum TypeOfMeal
    {
        Breakfast,
        Lunch,
        Pasta,
        Salad,
        Fish,
        Soup,
        Dessert
    }
    public class MealType
    {
        public int Id { get; set; }
        public TypeOfMeal TypeMeal { get; set; }
        public bool IsActive { get; set; }

        public MealType(int id, TypeOfMeal typeMeal, bool isActive)
        {
            Id = id;
            TypeMeal = typeMeal;
            IsActive = isActive;
        }
    }
}
