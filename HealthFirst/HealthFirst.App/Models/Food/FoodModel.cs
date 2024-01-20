using HealthFirst.App.Services;
using System.Collections.ObjectModel;

namespace HealthFirst.App.Models.Food
{
    public sealed class FoodModel
    {
        public IList<DishRecipeModel> Recipes { get; }

        public FoodModel()
        {
            Recipes = new ObservableCollection<DishRecipeModel>();
        }

        public FoodModel(IEnumerable<DishRecipeModel> dishRecipes)
        {
            Recipes = new ObservableCollection<DishRecipeModel>(dishRecipes);
        }

        public void AddRecipe(DishRecipeModel dishRecipeModel) 
        {
            Recipes.Add(dishRecipeModel);
        }

        public void RemoveRecipe(DishRecipeModel dishRecipeModel)
        {
            Recipes.Remove(dishRecipeModel);
        }

        public void SaveRecipes()
        {
            var s = new FoodService();
            s.SaveFoodModel(this);
        }
    }
}
