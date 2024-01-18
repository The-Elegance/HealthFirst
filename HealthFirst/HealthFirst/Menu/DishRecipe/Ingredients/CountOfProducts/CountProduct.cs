using HealthFirst.Core.Menu.DishRecipe.Ingredients.Gram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.Ingredients.CountOfProducts
{
    public readonly struct CountProduct : ICountProducts
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

        public CountProduct(int count, Unit unit)
        {
            Count = count;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"Count: {Count}{Unit}";
        }
    }
}
