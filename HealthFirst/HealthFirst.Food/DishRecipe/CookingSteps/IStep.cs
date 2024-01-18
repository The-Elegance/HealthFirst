namespace HealthFirst.Food.DishRecipe.CookingSteps
{
    public interface IStep
    {
        /// <summary>
        /// Step name
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Step description
        /// </summary>
        public string Description { get; set; }
    }
}
