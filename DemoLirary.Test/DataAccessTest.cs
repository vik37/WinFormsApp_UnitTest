using DemoLirary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DemoLirary.Test
{
    public class DataAccessTest
    {
        [Fact]
        public void AddPersonToPeopleList_ShouldWork()
        {
            PersonModels newPerson = new PersonModels { Firstname = "Viktor", Lastname = "Zafirovski" };
            List<PersonModels> people = new List<PersonModels>();

            DataAccess.AddPersonToPeopleList(people, newPerson);

            Assert.True(people.Count == 1);
            Assert.Contains<PersonModels>(newPerson, people);
        }
        [Theory]
        [InlineData("Viktor","", "Lastname")]
        [InlineData("", "Zafirovski", "Firstname")]
        public void AddPersonToPeopleList_ShouldFail(string firstName, string lastName, string param)
        {
            PersonModels newPerson = new PersonModels { Firstname = firstName, Lastname = lastName };
            List<PersonModels> people = new List<PersonModels>();

            Assert.Throws<ArgumentException>(param, () => DataAccess.AddPersonToPeopleList(people, newPerson));
        }
        [Fact]
        public void ConvertToCsv_ShouldConvertToCSVString()
        {
            List<string> expected = new List<string> { "Zafir,Hadjimanov", "Goce,Delcev" };

            List<PersonModels> people = new List<PersonModels>
            {
                new PersonModels{Firstname="Zafir",Lastname="Hadjimanov"},
                new PersonModels{Firstname="Goce",Lastname="Delcev"}
            };

            List<string> actual = DataAccess.ConvertToCsv(people);

            Assert.Equal(expected, actual);
            Assert.True(actual.Count > 0);
            Assert.Contains(actual, a => a.Contains(','));
        }
    }
}
