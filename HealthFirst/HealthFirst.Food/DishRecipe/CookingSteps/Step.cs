namespace HealthFirst.Food.DishRecipe.CookingSteps
{
    public class Step : IStep
    {
        /// <summary>
        /// Step name
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Step description
        /// </summary>
        public string Description { get; set; }

        public Step(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public override string ToString()
        {
            return $"Title: {Title} Description: {Description}";
        }
    }
}
