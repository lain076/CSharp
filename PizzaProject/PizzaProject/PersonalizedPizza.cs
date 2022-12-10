using System.ComponentModel.Design.Serialization;

namespace PizzaProject;

public class PersonalizedPizza : Pizza
{
    private static int pizzaNumber;
    public PersonalizedPizza() : base($"Personalized number : { pizzaNumber }", 5, null, false)
    {
        pizzaNumber++;
        Ingredients = GetIngredients();
        Price += (1.5f * Ingredients.Count);
    }

    private List<string> GetIngredients()
    {
        var ingredients = new List<string>();
        while (true)
        {
            Console.WriteLine($"Enter an ingredient for { Name } (return to quit)");
            var ingredient = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(ingredient)) return ingredients;

            if (ingredients.Contains(ingredient))
            {
                Console.WriteLine("Ingredient always in list");
                Console.WriteLine();
            }
            else
            {
                ingredients.Add(ingredient);    
                PrintIngredients(ingredients);
            }
            
            
        }
    }

    private void PrintIngredients(List<string> ingredients)
    {
        if (ingredients.Count > 0)
        {
            Console.WriteLine($"Ingredients list { Name }: { string.Join(", ", ingredients) }");
            Console.WriteLine();
        }
    }
}