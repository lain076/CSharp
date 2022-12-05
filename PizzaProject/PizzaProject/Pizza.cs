namespace PizzaProject;

public class Pizza
{
    public List<string> Ingredients { get; init; }

    public bool Vegetarian { get; init; }
    public float Price { get; init; }
    public string Name { get; init; }
    
    public Pizza(string name, float price, List<string> ingredients, bool vegetarian = false)
    {
        Name = name;
        Price = price;
        Vegetarian = vegetarian;
        Ingredients = ingredients;
    }

    public void PrintPizzaInfo()
    {
        var vegetarian = string.Empty;
        if (Vegetarian) vegetarian = "(V)";
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"Pizza {FormatFirstLetter(Name)} : {vegetarian} - {Price.ToString()} €");
        Console.WriteLine($"Ingredients : {String.Join(", ", FormatsIngredients(Ingredients))}");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("");
    }

    private List<string> FormatsIngredients(List<string> ingredientsToFormat)
    {
        return ingredientsToFormat.Select(i => FormatFirstLetter(i)).ToList();
    }

    private static string FormatFirstLetter(string words)
    {
        if (string.IsNullOrEmpty(words)) return "";
        return words.ToUpper()[0] + words.ToLower()[1..];
    }
}