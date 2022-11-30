﻿using System;
using System.Collections.Generic;
using peoplesList;

namespace PeoplesList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ShowPeoplesInformations(CreateList());
            People.ShowTotalOfPeoples();
            CreateStudent();

            Console.ReadLine();
        }

        private static void CreateStudent()
        {
            People headTeacher = new People("Jacques", 55, "Teacher");
            Student student00 = new Student("Tutus", 15, "Engineer", headTeacher);
            student00.PrintPeopleStudyInformations();
        }

        private static List<People> CreateList()
        {
            var peoples = new List<People>();
            peoples.Add(new People("Sam", 15, "Student"));
            peoples.Add(new People("David", 45, "Dev"));
            peoples.Add(new People("Grathy", 42));
            return peoples;
        }

        private static void ShowPeoplesInformations(List<People> peoples)
        {
            foreach (var people in peoples)
            {
                people.PrintPeopleJobInformations();
            }
        }
    }
}