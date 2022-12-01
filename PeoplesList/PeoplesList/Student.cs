using System;
using peoplesList;

namespace PeoplesList
{
    public class Student : People
    {
        private string _studyInformation;
        public People HeadTeacher { get; set; }

        public Student(string name, int age, string studyInformation) : base(name, age)
        {
            _studyInformation = studyInformation;
        }


        public void PrintPeopleStudyInformations()
        {
            PrintPeopleInformations();
            Console.WriteLine("");
            Console.WriteLine($"Informations : {_studyInformation}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            Console.WriteLine("Head teacher");
            if (HeadTeacher != null) HeadTeacher.PrintPeopleJobInformations();
            Console.WriteLine();
        }
    }
}