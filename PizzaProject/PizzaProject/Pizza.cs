namespace PizzaProject;

public class Pizza
{
    private string _name;
    private float _price;
    private bool _vegetarian;
    private List<string> _ingredients;
    
    public Pizza(string name,float price,List<string> ingredients, bool vegetarian = false)
    {
        _name = name;
        _price = price;
        _vegetarian = vegetarian;
        _ingredients = ingredients;
    }

    public void PrintPizzaInfo()
    {
        var vegetarian = string.Empty;
        if (_vegetarian) vegetarian = "(V)";
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine($"Pizza { FormatFirstLetter(_name) } : { vegetarian } - { _price.ToString() } €");
        Console.WriteLine($"Ingredients : { FormatFirstLetter(String.Join(", ",_ingredients)) }");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("");
    }

    private static string FormatFirstLetter(string words)
    {
        if (string.IsNullOrEmpty(words)) return "";
        return words.ToUpper()[0] + words.ToLower()[1..];
    }
}