using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DemoLirary;
using System.IO;

namespace DemoLirary.Test
{
    public class Examples
    {
        [Fact]
        public void ExampleLoadTestFile_ValidNameShouldWork()
        {
            string actual = ExampleWithLoadFile.ExampleLoadFiles("This is a valid fileame");

            Assert.True(actual.Length > 0);
        }
        [Fact]
        public void ExampleLoadTestFile_IvalidNameShouldFailed()
        {
            //Assert.Throws<FileNotFoundException>(() => ExampleWithLoadFile.ExampleLoadFiles(""));
            Assert.Throws<ArgumentException>("file", () => ExampleWithLoadFile.ExampleLoadFiles(""));
        }
    }
}
