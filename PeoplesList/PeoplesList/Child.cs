using System;
using peoplesList;

namespace PeoplesList
{
    public class Child : Student
    {
        private string _schoolGrade;

        public Child(string name, int age, string schoolGrade) : base(name, age, null)
        {
            _schoolGrade = schoolGrade;
        }

        public override void PrintInformations()
        {
            PrintPeopleInformations();
            Console.WriteLine("");
            Console.WriteLine($"School grade : {_schoolGrade}");
            Console.WriteLine("-----------------------------");
        }
    }
}