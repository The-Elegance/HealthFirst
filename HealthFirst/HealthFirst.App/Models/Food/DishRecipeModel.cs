using HealthFirst.Food.DishRecipe;
using HealthFirst.Food.DishRecipe.CookingSteps;
using HealthFirst.Food.DishRecipe.Ingredients;

namespace HealthFirst.App.Models.Food
{
    public class DishRecipeModel : IDishRecipe
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public TimeSpan CookingTime { get; set; }

        public uint CountServings { get; set; }

        public DifficultyPreparation Level { get; set; }

        public Ingredient[] Ingredients { get; set; }

        public Step[] CoockingStep { get; set; }

        public DishRecipeModel()
        {
            
        }

        public DishRecipeModel(IDishRecipe dishRecipe)
        {
            Title = dishRecipe.Title;
            Description = dishRecipe.Description;
            CookingTime = dishRecipe.CookingTime;
            CountServings = dishRecipe.CountServings;
            Level = dishRecipe.Level;
            Ingredients = dishRecipe.Ingredients;
            CoockingStep = dishRecipe.CoockingStep;
        }
    }
}
