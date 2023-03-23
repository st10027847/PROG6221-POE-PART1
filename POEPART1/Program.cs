using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPART1
{
    using System;

    namespace RecipeApp
    {
        class Recipe
        {

            //Declaration of the arrays used within the project.
            private string[] ingredientNames;
            private double[] ingredientQuantities;
            private string[] ingredientUnits;
            private string[] steps;

            // Accepts the user's input for the list of ingredients.
            public void EnterRecipeDetails()
            {
                Console.WriteLine("Enter the number of ingredients:");
                int numIngredients = int.Parse(Console.ReadLine());

                // Passing the numIngredients variable (Integer) into arrays.
                ingredientNames = new string[numIngredients];
                ingredientQuantities = new double[numIngredients];
                ingredientUnits = new string[numIngredients];

                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                    ingredientNames[i] = Console.ReadLine();

                    Console.WriteLine($"Enter the quantity of {ingredientNames[i]}:");
                    ingredientQuantities[i] = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter the unit of measurement for {ingredientNames[i]}:");
                    ingredientUnits[i] = Console.ReadLine();
                }

                Console.WriteLine("Enter the number of steps:");
                int numSteps = int.Parse(Console.ReadLine());

                steps = new string[numSteps];

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    steps[i] = Console.ReadLine();
                }
            }

            // The method below will display the provided recipe (provided using user input)
            public void DisplayRecipe()
            {
                Console.WriteLine("Ingredients:");

                for (int i = 0; i < ingredientNames.Length; i++)
                {
                    // String Interpolation*
                    Console.WriteLine($"{ingredientQuantities[i]} {ingredientUnits[i]} of {ingredientNames[i]}");
                }

                Console.WriteLine("\nSteps:");

                for (int i = 0; i < steps.Length; i++)
                {
                    // String Interpolation*
                    Console.WriteLine($"{i + 1}. {steps[i]}");
                }
            }

            // The below method (ScaleRecipe) will allow the user to adjust the scale of the recipe quantities.
            public void ScaleRecipe(double factor)
            {
                for (int i = 0; i < ingredientQuantities.Length; i++)
                {
                    ingredientQuantities[i] *= factor;
                }
            }

            // The below method (ResetQuantities) will allow the user to reset the quantities previously provided.
            public void ResetQuantities()
            {
                for (int i = 0; i < ingredientQuantities.Length; i++)
                {
                    ingredientQuantities[i] /= ingredientQuantities[i];
                }
            }

            // The ClearRecipe module allows the user to clear the previously provided quantities. 
            public void ClearRecipe()
            {
                ingredientNames = null;
                ingredientQuantities = null;
                ingredientUnits = null;
                steps = null;
            }
        }

        
    }

}

// * = Using a '$' sign will identify the string as a String literal.
// When an interpolated string is outputted, the items with interpolation will be replaced with the string representations of the expression results.

