using HealthFirst.Core.Menu.DishRecipe;
using HealthFirst.Core.Menu.DishRecipe.CookingSteps;
using HealthFirst.Core.Menu.DishRecipe.Ingredients;
using HealthFirst.Core.Menu.DishRecipe.Ingredients.CountOfProducts;
using HealthFirst.Core.Menu.DishRecipe.Ingredients.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HealthFirst.Tests
{
    [TestFixture]
    internal class MenuTest
    {
        [SetUp]
        public void SetUp()
        { }

        [Test]
        public void CreateCountOfProducts()
        {
            var newCount = new CountProduct(100, Unit.g);

            Assert.AreEqual(newCount.ToString(), "Count: 100g");
        }

        [Test]
        public void CreateIngredient()
        {
            var product = new Product("ТЕМНЫЙ ШОКОЛАД", "ТЕМНЫЙ ШОКОЛАД СОДЕРЖИТ ФЛАВОНОЛ, КОТОРЫЙ БОРЕТСЯ...");
            var newCount = new CountProduct(100, Unit.g);
            var newIngredient = new Ingredient(product, newCount);

            Assert.AreEqual(newIngredient.ToString(), $"ProductName: {product.Name} Count: {newCount.ToString}");
        }

        [Test]
        public void CreateCookingStep()
        {
            var newStep = new Step("Шаг 1", "Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане...");

            Assert.AreEqual(newStep.ToString(), "Title: Шаг 1 Description: Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане...");
        }

        [Test]
        public void CreateRecipe()
        {
            var title = "Брауни";
            var desc = "Один из самых популярных десертов в мире — брауни — был придуман в 1893 году...";
            var coockinTime = TimeSpan.FromMinutes(40);
            uint count = 6;
            var level = DifficultyPreparation.Medium;

            var product1 = new Product("ТЕМНЫЙ ШОКОЛАД", "ТЕМНЫЙ ШОКОЛАД СОДЕРЖИТ ФЛАВОНОЛ, КОТОРЫЙ БОРЕТСЯ...");
            var newCount1 = new CountProduct(100, Unit.g);
            var ingr1 = new Ingredient(product1, newCount1);

            var product2 = new Product("СЛИВОЧНОЕ МАСЛО", "ФОКУСОВ В ОБРАЩЕНИИ НА КУХНЕ СО СЛИВОЧНЫМ МАСЛОМ СУЩЕСТВУЕТ МНОЖЕСТВО.");
            var newCount2 = new CountProduct(180, Unit.g);
            var ingr2 = new Ingredient(product2, newCount2);

            Ingredient[] ingredients = [ingr1, ingr2];

            var newStep1 = new Step("Шаг 1", "Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане...");
            var newStep2 = new Step("Шаг 2", "Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане...");

            Step[] step = [newStep1, newStep2];

            var recipe = new DishRecipe(title, desc, coockinTime, count, level, ingredients, step);

            Assert.AreEqual(recipe.ToString(), "Title: Брауни " +
                "Description: Один из самых популярных десертов в мире — брауни — был придуман в 1893 году... " +
                "CookingTime: 00:40:00 CountServings: 6 Level: Medium " +
                $"Ingredients: ProductName: {product1.Name} Count: {newCount1.ToString}ProductName: {product2.Name} Count: {newCount2.ToString} " +
                "CoockingStep: Title: Шаг 1 Description: Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане...Title: Шаг 2 Description: Шоколад разломать на кусочки и вместе со сливочным маслом растопить на водяной бане...");
        }
    }
}
