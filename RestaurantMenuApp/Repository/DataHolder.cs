using RestaurantMenuApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.Repository
{
    public static class DataHolder
    {

        public static Ingredient TomatoSauce = new Ingredient(1, "Tomato sauce");
        public static Ingredient Cheese = new Ingredient(2, "Cheese"); 
        public static Ingredient Mushroom = new Ingredient(3, "Mushroom");
        public static Ingredient Oregano = new Ingredient(4, "Oregano");
        public static Ingredient Pepperoni = new Ingredient(5, "Pepperoni");
        public static Ingredient Onion = new Ingredient(6, "Onion");
        public static Ingredient Egg = new Ingredient(7, "Cheese");
        public static Ingredient Chicken = new Ingredient(8, "Chicken");
        public static Ingredient Bacon = new Ingredient(9, "Bacon");
        public static Ingredient Avocado = new Ingredient(10, "Avocado");
        public static Ingredient Pineapple = new Ingredient(11, "Pineapple");

        public static List<Ingredient> Ingredients = new List<Ingredient>()
        {
            TomatoSauce,
            Cheese,
            Mushroom,
            Oregano,
            Onion,
            Pepperoni,
            Egg,
            Chicken,
            Bacon,
            Avocado,
            Pineapple
        };

        public static List<MealType> MealTypes = new List<MealType>()
        {
            new MealType(1,TypeOfMeal.Breakfast,true),
            new MealType(2,TypeOfMeal.Dessert,false),
            new MealType(3,TypeOfMeal.Fish,false),
            new MealType(4,TypeOfMeal.Lunch,true),
            new MealType(5,TypeOfMeal.Pasta,true),
            new MealType(6,TypeOfMeal.Salad,true),
            new MealType(7,TypeOfMeal.Soup,false)
        };

        public static Meal Margherita = new Meal("Margherita pizza", 250, new List<Ingredient> { Cheese, TomatoSauce, Oregano }, 4, true);
        public static Meal EnglishBreakfast = new Meal("English Breakfast", 320, new List<Ingredient> { Bacon, Mushroom, Egg }, 1, false);

        public static List<Meal> Meals = new List<Meal>()
        {
            Margherita,EnglishBreakfast,
            new Meal("Pepperoni Pasta", 230, new List<Ingredient>{Pepperoni, Cheese, Mushroom}, 5, true),
            new Meal("Chicken Cheese", 280, new List<Ingredient>{Cheese, Chicken, Onion}, 4, false),
            new Meal("Green salad", 330, new List<Ingredient>{Avocado, Pepperoni, Oregano}, 6, true),
            new Meal("Fruit salad", 150, new List<Ingredient>{Pineapple,Avocado},6,true)
        };


    }
}
