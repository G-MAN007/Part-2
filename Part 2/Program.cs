using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErenYeager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecipeBook recipeBook = new RecipeBook();

            while (true)
            {
                Console.WriteLine("========= Recipe App =========");
                Console.WriteLine("1. Add Recipe");
                Console.WriteLine("2. Display Recipe List");
                Console.WriteLine("3. Display Recipe by Name");
                Console.WriteLine("4. Scale Recipe by Name");
                Console.WriteLine("5. Reset Quantities by Name");
                Console.WriteLine("6. Clear Recipe Book");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        recipeBook.AddRecipe();
                        break;
                    case 2:
                        recipeBook.DisplayRecipeList();
                        break;
                    case 3:
                        recipeBook.DisplayRecipeByName();
                        break;
                    case 4:
                        recipeBook.ScaleRecipeByName();
                        break;
                    case 5:
                        recipeBook.ResetQuantitiesByName();
                        break;
                    case 6:
                        recipeBook.ClearRecipeBook();
                        break;
                    case 7:
                        Console.WriteLine("Thank you for using the Recipe App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
