using HealthFirst.Food.DishRecipe.Ingredients.Gram;

namespace HealthFirst.Food.DishRecipe.Ingredients.CountOfProducts
{
    public readonly struct CountProduct : ICountProducts
    {
        /// <summary>
        /// Count of products
        /// Example: 100g flour,
        /// 100 - count
        /// </summary>
        public int Count { get; }
        /// <summary>
        /// Products units
        /// Example: 100g flour
        /// g - unit
        /// </summary>
        public Unit Unit { get; }

        public CountProduct(int count, Unit unit)
        {
            Count = count;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"Count: {Count}{Unit}";
        }
    }
}
