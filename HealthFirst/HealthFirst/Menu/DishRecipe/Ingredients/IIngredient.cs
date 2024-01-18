using HealthFirst.Core.Menu.DishRecipe.Ingredients.CountOfProducts;
using HealthFirst.Core.Menu.DishRecipe.Ingredients.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.Ingredients
{
    public interface IIngredient
    {
        /// <summary>
        /// Product name
        /// </summary>
        public Product Product { get; }
        /// <summary>
        /// Count of product
        /// </summary>
        public CountProduct Count { get; }

    }
}
