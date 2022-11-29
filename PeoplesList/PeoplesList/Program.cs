using System;
using System.Collections.Generic;
using peoplesList;

namespace PeoplesList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ShowPeoplesInformations(CreateList()); 
            People.ShowTotalOfPeoples();
            Console.ReadLine();
        }

        private static List<People> CreateList()
        {
            var peoples = new List<People>();
            peoples.Add(new People("Sam",15, "Student"));
            peoples.Add(new People("David",45, "Dev"));
            peoples.Add(new People("Grathy",42));
            return peoples;     
        }

        private static void ShowPeoplesInformations(List<People> peoples)
        {
            foreach(var people in peoples)
            {
                people.PrintPeopleInformations();
            }
        }
    }
}