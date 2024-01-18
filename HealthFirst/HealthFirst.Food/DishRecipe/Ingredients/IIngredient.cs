using HealthFirst.Food.DishRecipe.Ingredients.CountOfProducts;
using HealthFirst.Food.Products;

namespace HealthFirst.Food.DishRecipe.Ingredients
{
    public interface IIngredient
    {
        /// <summary>
        /// Product name
        /// </summary>
        Product Product { get; }
        /// <summary>
        /// Count of product
        /// </summary>
        CountProduct Count { get; }
    }
}
