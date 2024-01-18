using HealthFirst.Core.Menu.DishRecipe.Ingredients.CountOfProducts;
using HealthFirst.Core.Menu.DishRecipe.Ingredients.Gram;
using HealthFirst.Core.Menu.DishRecipe.Ingredients.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.Ingredients
{
    public class Ingredient : IIngredient
    {
        /// <summary>
        /// Name of ingredient
        /// </summary>
        public Product Product { get; }
        /// <summary>
        /// Count of product
        /// </summary>
        public CountProduct Count { get; }

        public Ingredient(Product product, CountProduct count)
        {
            Product = product;
            Count = count;
        }

        public override string ToString()
        {
            return $"ProductName: {Product.Name} Count: {Count.ToString}";
        }
    }
}
