using HealthFirst.Food.DishRecipe;
using HealthFirst.Json.Core;

namespace HealthFirst.Json.App
{
    public class FoodListService : IDataListService<IDishRecipe>
    {
        private readonly string _path;
        private readonly JsonTool<IEnumerable<IDishRecipe>> _jsonTool;

        public FoodListService(string path)
        {
            _path = path;
            _jsonTool = new JsonTool<IEnumerable<IDishRecipe>>();
        }

        public IEnumerable<IDishRecipe> Read()
        {
            return _jsonTool.Deserialize(_path);
        }

        public void Write(IEnumerable<IDishRecipe> dishRecipe)
        {
            _jsonTool.Serialize(dishRecipe, _path);
        }
    }
}
