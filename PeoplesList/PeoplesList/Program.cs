using System;
using System.Collections.Generic;
using peoplesList;

namespace PeoplesList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var peoples = CreateList(); 
            Console.ReadLine();
        }

        public static List<People> CreateList()
        {
            var peoples = new List<People>();
            peoples.Add(new People("Sam", "Student", 15));
            peoples.Add(new People("David", "Dev", 45));
            peoples.Add(new People("Grathy", "Secretary", 42));
            return peoples;     
        }
    }
}