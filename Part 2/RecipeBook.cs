using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenYeager
{
    internal class RecipeBook
    {
        private List<Recipe> recipes;

        public RecipeBook()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe()
        {
            Console.Write("Enter recipe name: ");
            string name = Console.ReadLine();

            Recipe recipe = new Recipe(name);

            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ingredientCount; i++)
            {
                Console.WriteLine($"Enter details for Ingredient #{i + 1}:");
                Console.Write("Name: ");
                string ingredientName = Console.ReadLine();
                Console.Write("Quantity: ");
                double quantity = Convert.ToDouble(Console.ReadLine());
                Console.Write("Unit of Measurement: ");
                string unit = Console.ReadLine();
                Console.Write("Calories: ");
                int calories = Convert.ToInt32(Console.ReadLine());
                Console.Write("Food Group: ");
                string foodGroup = Console.ReadLine();
                recipe.AddIngredient(ingredientName, quantity, unit, calories, foodGroup);
            }

            Console.Write("Enter the number of steps: ");
            int stepCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < stepCount; i++)
            {
                Console.WriteLine($"Enter Step #{i + 1}:");
                string step = Console.ReadLine();
                recipe.AddStep(step);
            }

            recipes.Add(recipe);
            Console.WriteLine("Recipe added successfully!");
        }

        public void DisplayRecipeList()
        {
            Console.WriteLine("Recipes in Recipe Book:");
            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            foreach (Recipe recipe in recipes.OrderBy(r => r.Name))
            {
                Console.WriteLine(recipe.Name);
            }
        }

        public void DisplayRecipeByName()
        {
            Console.WriteLine("Enter the name of the recipe to display:");
            string recipeName = Console.ReadLine();

            Recipe recipe = recipes.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                recipe.DisplayRecipe();
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
        }

        public void ScaleRecipeByName()
        {
            Console.WriteLine("Enter the name of the recipe to scale:");
            string recipeName = Console.ReadLine();

            Recipe recipe = recipes.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                Console.WriteLine("Enter the scaling factor (0.5, 2, or 3):");
                double factor = Convert.ToDouble(Console.ReadLine());

                recipe.ScaleRecipe(factor);
                Console.WriteLine("Recipe scaled successfully!");
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
        }

        public void ResetQuantitiesByName()
        {
            Console.WriteLine("Enter the name of the recipe to reset quantities:");
            string recipeName = Console.ReadLine();

            Recipe recipe = recipes.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (recipe != null)
            {
                recipe.ResetQuantities();
                Console.WriteLine("Quantities reset successfully!");
            }
            else
            {
                Console.WriteLine("Recipe not found!");
            }
        }

        public void ClearRecipeBook()
        {
            recipes.Clear();
            Console.WriteLine("Recipe book cleared!");
        }

    }
}
