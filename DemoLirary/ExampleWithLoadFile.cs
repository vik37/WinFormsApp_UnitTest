using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLirary
{
    public static class ExampleWithLoadFile
    {
        public static string ExampleLoadFiles(string file)
        {
            if (file.Length < 10)
            {
                //throw new System.IO.FileNotFoundException();
                throw new ArgumentException("The file name was too short", "file");
            }
            return "The file was correctly loaded.";
        }
    }
}
