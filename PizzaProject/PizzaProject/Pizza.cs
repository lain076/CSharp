namespace PizzaProject;

public class Pizza
{
    private bool _vegetarian;
    private List<string> _ingredients;

    public float Price { get; init; }
    public string Name { get; init; }
    
    public Pizza(string name, float price, List<string> ingredients, bool vegetarian = false)
    {
        Name = name;
        Price = price;
        _vegetarian = vegetarian;
        _ingredients = ingredients;
    }

    public void PrintPizzaInfo()
    {
        var vegetarian = string.Empty;
        if (_vegetarian) vegetarian = "(V)";
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"Pizza {FormatFirstLetter(Name)} : {vegetarian} - {Price.ToString()} €");
        Console.WriteLine($"Ingredients : {String.Join(", ", FormatsIngredients(_ingredients))}");
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