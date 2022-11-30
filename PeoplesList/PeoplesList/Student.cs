using System;
using peoplesList;

namespace PeoplesList
{
    public class Student : People
    {
        private string _studyInformation;
        public Student(string name, int age, string studyInformation = "No informations given") : base(name, age)
        {
            _studyInformation = studyInformation;
        }
        
        

        public override void PrintPeopleInformations()
        {
            Console.WriteLine($"Name : {_name}");
            Console.WriteLine($"Age  : {_age}");
            Console.WriteLine($"Informations : {_studyInformation}");
            Console.WriteLine($"Number  : {_number}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
        }
    }
}