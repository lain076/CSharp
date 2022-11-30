using System;
using peoplesList;

namespace PeoplesList
{
    public class Student : People
    {
        private string _studyInformation;
        private People _headTeacher;
        public Student(string name, int age, string studyInformation, People headTeacher = null) : base(name, age)
        {
            _studyInformation = studyInformation;
            _headTeacher = headTeacher;
        }
        
        

        public void PrintPeopleStudyInformations()
        {
            PrintPeopleInformations();
            Console.WriteLine("");
            Console.WriteLine($"Informations : {_studyInformation}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            Console.WriteLine("Head teacher");
            if (_headTeacher != null) _headTeacher.PrintPeopleJobInformations();
            Console.WriteLine();
        }
    }
}