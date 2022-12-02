using System;

namespace peoplesList
{
    public class People
    {
        private static short _peopleNumber;

        public string Name { get; private set; }
        private readonly string _job;
        public int Age { get; private set; }
        private readonly int _number;

        public People(string name, int age, string job = "No job specified")
        {
            Name = name;
            _job = job;
            Age = age;
            _number = _peopleNumber++;
        }
        public virtual void PrintInformations()
        {
            PrintPeopleInformations();  
        }
        protected void PrintPeopleInformations()
        {
            Console.WriteLine($"People informations");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age  : {Age}");
            Console.WriteLine($"Number  : {_number}");
            Console.WriteLine($"");
        }
        public static void ShowTotalOfPeoples()
        {
            var totalNumberOfPeoples = String.Empty;
            if (_peopleNumber < 10) totalNumberOfPeoples = "0";
            totalNumberOfPeoples += _peopleNumber.ToString();
            Console.WriteLine("");
            Console.WriteLine($"Total number of peoples : {totalNumberOfPeoples}");
        }
    }
}