using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe.CookingSteps
{
    public interface IStep
    {
        /// <summary>
        /// Step name
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Step description
        /// </summary>
        public string Description { get; set; }
    }
}
