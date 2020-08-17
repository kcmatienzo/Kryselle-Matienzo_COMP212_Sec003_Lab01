using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kryselle_Matienzo_Exercise02
{
    class ExtensionMethodTest
    {
        static void Main(string[] args)
        {
            // initializing StringBuilder object
            StringBuilder sb = new StringBuilder();

            string strobj = "This is to test whether the extension method count can return a right answer or not";
            Console.WriteLine(strobj);
            Console.WriteLine($"Number of words: {sb.CountWords(strobj)}");

            strobj = "You can define extension methods for user defined types as well as predefined types";
            Console.WriteLine(strobj);
            Console.WriteLine($"Number of words: {sb.CountWords(strobj)}");
        }  // end Main()  
    }
}
