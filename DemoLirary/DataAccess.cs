using DemoLirary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoLirary
{
    public static class DataAccess
    {
        private static string personTextFile = @"PersonText.txt";

        public static void AddNewPerson(PersonModels person)
        {
            List<PersonModels> people = GetAll();
            AddPersonToPeopleList(people, person);

            List<string> lines = ConvertToCsv(people);

            File.WriteAllLines(personTextFile, lines);
        }

        public static void AddPersonToPeopleList(List<PersonModels> people, PersonModels person)
        {
            if (string.IsNullOrEmpty(person.Firstname))
            {
                throw new ArgumentException("You passed in an invalid parameter", "FirstName");
            }
            if (string.IsNullOrEmpty(person.Lastname))
            {
                throw new ArgumentException("You passed in an invalid parameter", "LastName");
            }
            people.Add(person);
        }
        public static List<string> ConvertToCsv(List<PersonModels> people)
        {
            List<string> output = new List<string>();
            foreach (PersonModels person in people)
            {
                output.Add($"{person.Firstname} {person.Lastname}");
            }
            return output;
        }
        public static List<PersonModels> GetAll()
        {
            List<PersonModels> output = new List<PersonModels>();
            string[] content = File.ReadAllLines(personTextFile);
            foreach(string line in content)
            {
                string[] data = line.Split(',');
                output.Add(new PersonModels { Firstname = data[0], Lastname = data[1] });
            }
            return output;
        }
    }
}
