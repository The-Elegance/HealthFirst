using HealthFirst.Food.DishRecipe.CookingSteps;
using HealthFirst.Food.DishRecipe.Ingredients;

namespace HealthFirst.Food.DishRecipe
{
    public class DishRecipe : IDishRecipe, IMenuItem
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

        public DishRecipe(string title, string desc, TimeSpan coockinTime, uint count, DifficultyPreparation level, Ingredient[] ingredients, Step[] step)
        {
            Title = title;
            Description = desc;
            CookingTime = coockinTime;
            CountServings = count;
            Level = level;
            Ingredients = ingredients;
            CoockingStep = step;
        }

        public override string ToString()
        {
            var ingredients = "";
            foreach (var ingr in Ingredients)
            {
                ingredients += ingr.ToString();
            }

            var steps = "";
            foreach (var step in CoockingStep)
            {
                steps += step.ToString();
            }

            return $"Title: {Title} Description: {Description} CookingTime: {CookingTime} CountServings: {CountServings} Level: {Level} Ingredients: {ingredients} CoockingStep: {steps}";
        }
    }
}
