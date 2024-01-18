using HealthFirst.Core.Menu.DishRecipe.CookingSteps;
using HealthFirst.Core.Menu.DishRecipe.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Core.Menu.DishRecipe
{
    public interface IDishRecipe
    {
        /// <summary>
        /// Recipe name
        /// </summary>
        public string Title { get; }
        /// <summary>
        /// Recipe description
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Coocking time
        /// </summary>
        public TimeSpan CookingTime { get; }
        /// <summary>
        /// Count of servings
        /// </summary>
        public uint CountServings { get; }
        /// <summary>
        /// Difficulty preparation the dish
        /// </summary>
        public DifficultyPreparation Level { get; }
        /// <summary>
        /// List of ingredients
        /// </summary>
        public Ingredient[] Ingredients { get; }
        /// <summary>
        /// Description of coocking step
        /// </summary>
        public Step[] CoockingStep { get; }
    }
}
