namespace HealthFirst.Food.Products
{
    public interface IProduct
    {
        /// <summary>
        /// Name of ingredient
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Description of ingredient
        /// </summary>
        public string Description { get; }
    }
}
