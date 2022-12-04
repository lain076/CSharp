using System;
using System.Text;

namespace PizzaProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static List<Pizza> Pizzas = new List<Pizza>();
        private static Pizza MostExpensivePizza = null;
        private static Pizza LessExpensivePizza = null;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreatePizzas();
            FindMostAndLessExpensivePizzas();
            Pizzas = Pizzas.OrderBy(p => p.Price).ToList();

            PrintPizzas();
            PrintMostAndLessExpensivePizzas();
        }

        private static void CreatePizzas()
        {
            Pizzas.Add(new Pizza("4 fromages", 11.5F,
                new List<string>() {"Conté", "gruyère", "fromfrom", "parmesant"}));
            Pizzas.Add(new Pizza("Champignons", 9.5F, new List<string>() {"Fungis", "champis", "amanite", "tomates"},
                true));
            Pizzas.Add(new Pizza("Bolognèse", 10F,
                new List<string>() {"tomates", "poivrons", "haché boeuf", "oignon"}));
            Pizzas.Add(new Pizza("4 saisons", 15F, new List<string>() {"Fungis", "oignon", "courgette", "saumon"}));
            Pizzas.Add(new Pizza("Arabiata", 9F, new List<string>() {"arabia", "ail", "saucisson", "Tomates"}, true));
        }

        private static void PrintPizzas()
        {
            foreach (var pizza in Pizzas)
            {
                pizza.PrintPizzaInfo();
            }
        }

        private static void PrintMostAndLessExpensivePizzas()
        {
            Console.WriteLine();
            Console.WriteLine($"The most expensive pizza is : {MostExpensivePizza.Name}");
            Console.WriteLine($"The less expensive pizza is : {LessExpensivePizza.Name}");
        }

        private static void FindMostAndLessExpensivePizzas()
        {
            foreach (var pizza in Pizzas)
            {
                MostExpensivePizza = GetMostExpensivePizza(pizza);
                LessExpensivePizza = GetLessExpensivePizza(pizza);
            }
        }

        private static Pizza GetMostExpensivePizza(Pizza pizza)
        {
            if (MostExpensivePizza == null) MostExpensivePizza = pizza;
            return MostExpensivePizza.Price < pizza.Price ? pizza : MostExpensivePizza;
        }

        private static Pizza GetLessExpensivePizza(Pizza pizza)
        {
            if (LessExpensivePizza == null) LessExpensivePizza = pizza;
            return LessExpensivePizza.Price > pizza.Price ? pizza : MostExpensivePizza;
        }
    }
}