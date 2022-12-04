using System;
using System.Text;

namespace PizzaProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static List<Pizza> Pizzas = new List<Pizza>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CreatePizzas();

            Pizzas = Pizzas.OrderByDescending(p => p.Price).ToList();
            
            PrintPizzas();
        }

        private static void CreatePizzas()
        {
            Pizzas.Add(new Pizza("4 fromages", 11.5F,new List<string>(){"Conté","gruyère","fromfrom","parmesant"}));
            Pizzas.Add(new Pizza("Champignons", 9.5F,new List<string>(){"Fungis","champis","amanite","tomates"}, true));
            Pizzas.Add(new Pizza("Bolognèse", 10F, new List<string>(){"tomates","poivrons","haché boeuf","oignon"}));
            Pizzas.Add(new Pizza("4 saisons", 15F,new List<string>(){"Fungis","oignon","courgette","saumon"}));
            Pizzas.Add(new Pizza("Arabiata", 9F,new List<string>(){"arabia","ail","saucisson","Tomates"}, true));
        }

        private static void PrintPizzas()
        {
            foreach (var pizza in Pizzas)
            {
                pizza.PrintPizzaInfo();
            }
        }
    }
}