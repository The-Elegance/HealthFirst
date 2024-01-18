using HealthFirst.Food.DishRecipe.CookingSteps;
using HealthFirst.Food.DishRecipe.Ingredients;

namespace HealthFirst.Food.DishRecipe
{
    public interface IDishRecipe
    {
        /// <summary>
        /// Recipe name
        /// </summary>
        string Title { get; }
        /// <summary>
        /// Recipe description
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Coocking time
        /// </summary>
        TimeSpan CookingTime { get; }
        /// <summary>
        /// Count of servings
        /// </summary>
        uint CountServings { get; }
        /// <summary>
        /// Difficulty preparation the dish
        /// </summary>
        DifficultyPreparation Level { get; }
        /// <summary>
        /// List of ingredients
        /// </summary>
        Ingredient[] Ingredients { get; }
        /// <summary>
        /// Description of coocking step
        /// </summary>
        Step[] CoockingStep { get; }
    }
}
