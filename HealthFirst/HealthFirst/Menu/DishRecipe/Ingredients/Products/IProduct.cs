using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.Ingredients.Products
{
    public interface IProduct
    {
        /// <summary>
        /// Name of ingredient
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Description of ingredient
        /// </summary>
        public string Description { get; }
    }
}
