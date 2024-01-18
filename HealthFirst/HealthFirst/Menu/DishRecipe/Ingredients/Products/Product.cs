using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.Ingredients.Products
{
    public class Product
    {
        /// <summary>
        /// Name of ingredient
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Description of ingredient
        /// </summary>
        public string Description { get; }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"Name: {Name} Description: {Description}";
        }
    }
}
