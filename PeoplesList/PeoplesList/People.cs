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

        public People(string name, int age, string job = null)
        {
            _name = name;
            _job = job;
            _age = age;
            _number = _peopleNumber++;
        }

        public void PrintPeopleInformations()
        {
            Console.WriteLine($"Name : {_name}");
            if(_job == null)
            {
                Console.WriteLine("Job  : No job specified");
            }
            else
            {
                Console.WriteLine($"Job  : {_job}");    
            }
            
            Console.WriteLine($"Age  : {_age}");
            Console.WriteLine($"Number  : {_number}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }

        public static void ShowTotalOfPeoples()
        {
            Console.WriteLine($"Peoples total : {_peopleNumber}");
        }
    }
}