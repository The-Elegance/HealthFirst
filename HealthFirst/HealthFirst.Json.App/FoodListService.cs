using HealthFirst.Food.DishRecipe;
using HealthFirst.Json.Core;

namespace HealthFirst.Json.App
{
    public sealed class FoodListService : IDataListService<IDishRecipe>
    {
        const string fileName = "food.json";
        private readonly JsonTool<IEnumerable<IDishRecipe>> _jsonTool;

        public FoodListService(string dirPath)
        {
            _jsonTool = new JsonTool<IEnumerable<IDishRecipe>>(dirPath, fileName);
        }

        public IEnumerable<IDishRecipe> Read()
        {
            return _jsonTool.Deserialize();
        }

        public void Write(IEnumerable<IDishRecipe> dishRecipe)
        {
            _jsonTool.Serialize(dishRecipe);
        }
    }
}
