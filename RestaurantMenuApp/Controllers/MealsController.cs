using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenuApp.Models;
using RestaurantMenuApp.Repository;
using RestaurantMenuApp.ViewModels;

namespace RestaurantMenuApp.Controllers
{
    public class MealsController : Controller
    {
        // GET: Meals
        public ActionResult Index()
        {
            return View(DataHolder.Meals);
        }

        // GET: Meals/Create
        public ActionResult Create()
        {
            var createViewModel = new CreateViewModel
            {
                MealTypes = DataHolder.MealTypes,
                Ingredients = DataHolder.Ingredients
            };
            return View(createViewModel);
        }

        // POST: Meals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateViewModel createViewModel)
        {
            if (ModelState.IsValid)
            {
                List <Ingredient> ingredients = new List<Ingredient>();
                int[] arrayIndexes = createViewModel.ChosenIngredients.ToArray<int>();

                foreach(var i in arrayIndexes)
                {
                    Ingredient ingredient=DataHolder.Ingredients.First(ing => ing.Id == i);
                    ingredients.Add(ingredient);
                }
                Meal meal = new Meal(createViewModel.Name, createViewModel.Price, ingredients, createViewModel.MealTypeId, createViewModel.IsVegetarian);
                DataHolder.Meals.Add(meal);
                return RedirectToAction("Index");

            }
            createViewModel.Ingredients = DataHolder.Ingredients;
            createViewModel.MealTypes = DataHolder.MealTypes;
            return View(createViewModel);
        }

        // GET: Meals/Breakfast/meals
        [Route("menu/{type}/meals")]
        public ActionResult Get(string type)
        {
            Helper.CheckAndWrite(type + " - " + DateTime.Now);
            List<Meal> meals = DataHolder.Meals.Where(m => m.MealType.TypeMeal.ToString().ToLower().Equals(type.ToLower())).ToList();
            return View("Index", meals);
        }

        //DELETE meals/delete/5
        [HttpDelete]
        public ActionResult Delete(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            Meal meal = DataHolder.Meals.First(meal => meal.Id == id);
            if(meal == null)
            {
                return NotFound();
            }
            DataHolder.Meals.Remove(meal);
            return RedirectToAction("Index");
        }




    }
}