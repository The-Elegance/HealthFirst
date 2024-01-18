using HealthFirst.Food.DishRecipe.Ingredients.CountOfProducts;
using HealthFirst.Food.Products;

namespace HealthFirst.Food.DishRecipe.Ingredients
{
    public class Ingredient : IIngredient
    {
        /// <summary>
        /// Name of ingredient
        /// </summary>
        public Product Product { get; }
        /// <summary>
        /// Count of product
        /// </summary>
        public CountProduct Count { get; }

        public Ingredient(Product product, CountProduct count)
        {
            Product = product;
            Count = count;
        }

        public override string ToString()
        {
            return $"ProductName: {Product.Name} Count: {Count.ToString}";
        }
    }
}
