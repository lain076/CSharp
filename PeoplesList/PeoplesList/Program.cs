using System;
using System.Collections.Generic;
using System.Linq;
using peoplesList;

namespace PeoplesList
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            var multiplicationTable = new MultiplicationTable(2);
            multiplicationTable.showTable();
            
            var peopleList = CreateList();
            ShowPeoplesInformations(peopleList);
            People.ShowTotalOfPeoples();
        }
        private static void CreateChild()
        {
            Child child00 = new Child("Sophie", 7, "CP", InitSchoolNotes(9, 8.5f, 7.4f));
            child00.PrintInformations();
        }
        private static Dictionary<string, float> InitSchoolNotes(float math, float geo, float science)
        {
            Dictionary<string, float> schoolNotes;
            schoolNotes = new Dictionary<string, float>();
            schoolNotes.Add("Math", math);
            schoolNotes.Add("Geo", geo);
            schoolNotes.Add("Science", science);
            return schoolNotes;
        }
        private static void CreateStudent()
        {
            People headTeacher = new People("Jacques", 55, "Teacher");
            Student student00 = new Student("Tutus", 15, "Engineer");

            student00.HeadTeacher = headTeacher;
            student00.PrintInformations();
        }
        private static List<People> CreateList()
        {
            var peoples = new List<People>();
            peoples.Add(new People("Sam", 15, "Student"));
            peoples.Add(new People("David", 45, "Dev"));
            peoples.Add(new People("Grathy", 42));
            peoples.Add(new Student("Tutus", 15, "Enginner"));
            peoples.Add(new Child("Delphine", 8, "CP", null));
            return peoples;
        }
        private static void ShowPeoplesInformations(List<People> peoples)
        {
            Console.WriteLine("");
            foreach (var people in peoples)
            {
                people.PrintInformations();
            }

            Console.WriteLine("-------------------------------------------");
        }
    }
}