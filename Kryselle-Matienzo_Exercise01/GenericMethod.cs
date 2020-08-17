using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Kryselle_Matienzo_Exercise01
{
    class GenericMethod
    {
        static void Main(string[] args)
        {
            //create arrays of int and string
            string[] dogList = { "Yorkie", "Maltese", "Doberman", "Poodle", "Labrador", "Pugg", "Husky", "Shih Tzu", "Pomeranian", "Beagle" };
            int[] intArray = { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.Write("Displaying dogList array: ");
            DisplayArray(dogList);
            Console.WriteLine();
            Console.Write("Displaying intArray: ");
            DisplayArray(intArray);
            Console.WriteLine();

            Console.WriteLine("Searching for Poodle");
            Console.WriteLine($"Index number: {Search(dogList, "Poodle")}"); // Search method with element in the list
            Console.WriteLine();

            Console.WriteLine("Searching for cat");
            Console.WriteLine($"Index number: {Search(dogList, "cat")}"); // Search method without element in the list -- will return -1
            Console.WriteLine();

            Console.WriteLine("Searching for number 16");
            Console.WriteLine($"Index number: {Search(intArray, 16)}"); // Search method with element in the list
            Console.WriteLine();

            Console.WriteLine("Searching for number 100");
            Console.WriteLine($"Index number: {Search(intArray, 100)}"); // Search method without element in the list -- will return -1
        } // end main()

        // Search method
        private static int Search<T>(T[] dataArray, T searchKey) where T : IComparable<T>
        {
            int index = 0;

            foreach (T element in dataArray)
            {
                // compare element in the array with searchkey
                if (element.CompareTo(searchKey) == 0)
                {
                    return index;
                    
                }
                index++;
            }
            return -1;
        } // end Search method

        // method to display/print/output the elements of an array
        private static void DisplayArray<T>(T[] displayArray)
        {
            foreach (T element in displayArray)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        } // end DisplayArray method
    }
}
