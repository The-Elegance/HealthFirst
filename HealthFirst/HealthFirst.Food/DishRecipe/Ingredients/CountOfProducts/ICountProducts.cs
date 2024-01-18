using HealthFirst.Food.DishRecipe.Ingredients.CountOfProducts;

namespace HealthFirst.Food.DishRecipe.Ingredients.Gram
{
    public interface ICountProducts
    {
        /// <summary>
        /// Count of products
        /// Example: 100g flour,
        /// 100 - count
        /// </summary>
        int Count { get; }
        /// <summary>
        /// Products units
        /// Example: 100g flour
        /// g - unit
        /// </summary>
        Unit Unit { get; }
    }
}
