using HealthFirst.App.Models.Food;
using HealthFirst.Food.DishRecipe;
using HealthFirst.Json.App;

namespace HealthFirst.App.Services
{
    public class FoodService
    {
        private readonly IDataListService<IDishRecipe> _foodListService;


        #region Constructors


        public FoodService()
        {
            _foodListService = new FoodListService(AppSettings.AppPath);
        }

        public FoodService(IDataListService<IDishRecipe> _dataListService)
        {
            _foodListService = _dataListService;
        }


        #endregion Constructors


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
