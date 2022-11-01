using System;
using peoplesList;

namespace PeoplesList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello samsam");
            Console.ReadLine();

            var people = new People("Sam","Student",15);
            
            people.PrintPeopleInformations();
            Console.ReadLine();
        }
    }
}