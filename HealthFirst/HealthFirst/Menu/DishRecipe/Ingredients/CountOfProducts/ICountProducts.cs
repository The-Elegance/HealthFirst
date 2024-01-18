using HealthFirst.Core.Menu.DishRecipe.Ingredients.CountOfProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.Ingredients.Gram
{
    public interface ICountProducts
    {
        /// <summary>
        /// Count of products
        /// Example: 100g flour,
        /// 100 - count
        /// </summary>
        public int Count { get; }
        /// <summary>
        /// Products units
        /// Example: 100g flour
        /// g - unit
        /// </summary>
        public Unit Unit { get; }
    }
}
