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
    public class SuppliesController : Controller
    {
        // GET: Supplies
        public ActionResult Index()
        {
            return View(DataHolder.Supplies);
        }

        // GET: Supplies/Details/5
        public ActionResult Details(int id)
        {
            Supply supply = DataHolder.Supplies.First(s => s.Ingredient.Id == id);
            return View(supply);
        }

        // GET: Meals/Create
        public ActionResult Create()
        {
            List<int> chosenIngredientsIndexes = DataHolder.Supplies.Select(s => s.Ingredient.Id).ToList();
            var createSypplyViewModel = new CreateSupplyViewModel
            {
                AvailableIngredients = DataHolder.Ingredients.Where(i => !chosenIngredientsIndexes.Contains(i.Id)).ToList()
            };
            return View(createSypplyViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateSupplyViewModel createSupplyViewModel)
        {
            if (ModelState.IsValid)
            {
                Ingredient ingredient = DataHolder.Ingredients.First(i => i.Id == createSupplyViewModel.chosenIngredient);
                Supply supply = new Supply(ingredient, createSupplyViewModel.Quantity, createSupplyViewModel.DateOfExpiration);
                DataHolder.Supplies.Add(supply);
                return RedirectToAction("Index");

            }
            List<int> chosenIngredientsIndexes = DataHolder.Supplies.Select(s => s.Ingredient.Id).ToList();
            createSupplyViewModel.AvailableIngredients = DataHolder.Ingredients.Where(i => !chosenIngredientsIndexes.Contains(i.Id)).ToList();
            return View(createSupplyViewModel);
        }


        // GET: Supplies/Edit/5
        public ActionResult Edit(int id)
        {
            Supply supply = DataHolder.Supplies.First(s => s.Ingredient.Id == id);
            return View(supply);
        }

        // POST: Supplies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Supply supply)
        {
            try
            {
                int indexOfSupplyToEdit = DataHolder.Supplies.FindIndex(s => s.Ingredient.Id == id);
                DataHolder.Supplies[indexOfSupplyToEdit] = supply;
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return BadRequest();
            }
            

        }

        [HttpDelete]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            Supply supply = DataHolder.Supplies.First(s => s.Ingredient.Id == id);
            if (supply == null)
            {
                return NotFound();
            }
            DataHolder.Supplies.Remove(supply);
            return RedirectToAction("Index");
        }
    }
}