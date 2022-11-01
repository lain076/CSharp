using System;

namespace peoplesList
{
    public class People
    {
        private readonly string _name;
        private readonly string _job;
        private readonly int _age;

        public People(string name, string job, int age)
        {
            _name = name;
            _job = job;
            _age = age;
        }

        public void PrintPeopleInformations()
        {
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Job  : " + _job);
            Console.WriteLine("Age  : " + _age);
        }
        
    }
}