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
        public override void PrintInformations()
        {
            PrintPeopleInformations();  
            Console.WriteLine($"Informations : {_studyInformation}");
            Console.WriteLine("-----------------------------");
            if (HeadTeacher != null) PrintHeadTeacher(HeadTeacher);
        }
        private void PrintHeadTeacher(People headTeacher)
        {
            Console.WriteLine("");
            Console.WriteLine("Head teacher");
            HeadTeacher.PrintInformations();
            Console.WriteLine();
        }
    }
}