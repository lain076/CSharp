using System;

namespace peoplesList
{
    public class People
    {
        private static short _peopleNumber;

        private readonly string _name;
        private readonly string _job;
        private readonly int _age;
        private readonly int _number;

        public People(string name, int age, string job = "No job specified")
        {
            _name = name;
            _job = job;
            _age = age;
            _number = _peopleNumber++;
        }
        public virtual void PrintInformations()
        {
            PrintPeopleInformations();  
        }
        protected void PrintPeopleInformations()
        {
            Console.WriteLine($"People informations");
            Console.WriteLine($"Name : {_name}");
            Console.WriteLine($"Age  : {_age}");
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