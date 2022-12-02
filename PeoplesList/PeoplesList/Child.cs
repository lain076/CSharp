using System;
using System.Collections.Generic;
using peoplesList;

namespace PeoplesList
{
    public class Child : Student
    {
        private string _schoolGrade;
        Dictionary<string, float> _schoolNotes;

        public Child(string name, int age, string schoolGrade, Dictionary<string, float> schoolNotes) : base(name, age,
            null)
        {
            _schoolGrade = schoolGrade;
            _schoolNotes = schoolNotes;
        }

        public override void PrintInformations()
        {
            PrintPeopleInformations();
            Console.WriteLine("");
            Console.WriteLine($"School grade : {_schoolGrade}");
            Console.WriteLine("-----------------------------");
            if ((_schoolNotes != null) && (_schoolNotes.Count > 0)) ShowSchoolNotes();
        }

        private void ShowSchoolNotes()
        {
            Console.WriteLine("");
            Console.WriteLine("School notes");
            foreach (var note in _schoolNotes) Console.WriteLine($"{note.Key} : {note.Value}/10");
            Console.WriteLine("");
        }
    }
}