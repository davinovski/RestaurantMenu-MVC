using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuApp.Models
{
    public class Ingredient
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public Ingredient(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Ingredient()
        {
        }
    }
}
