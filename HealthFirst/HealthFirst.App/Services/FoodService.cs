using HealthFirst.App.Models.Food;
using HealthFirst.Food.DishRecipe;
using HealthFirst.Json.App;

namespace HealthFirst.App.Services
{
    public class FoodService
    {
        const string filePath = "food.json";

        private readonly FoodListService _foodListService;

        public FoodService() 
        {
            _foodListService = new FoodListService(filePath);
        }

        public void SaveFoodModel(FoodModel food) 
        {
            var list = new List<IDishRecipe>();

            foreach (var recipe in food.Recipes) 
            {
                var dishRecipe = new DishRecipe(
                    recipe.Title, 
                    recipe.Description, 
                    recipe.CookingTime,
                    recipe.CountServings,
                    recipe.Level,
                    recipe.Ingredients,
                    recipe.CoockingStep);

                list.Add(dishRecipe);
            }

            _foodListService.Write(list);
        }

        public FoodModel GetFoodModel()
        {
            var data = _foodListService.Read();
            return new FoodModel(data.Select(r => new DishRecipeModel(r)));
        }
    }
}
