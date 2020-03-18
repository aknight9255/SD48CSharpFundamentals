using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypeExamples
    {
        

        [TestMethod]
        public void Strings()
        {
            string thisIsDeclaration;
            string declared;
            declared = "This is initialized.";
            string declarationAndInitialization = "This is both declaring and initializing.";


            string firstName = "Amanda";
            string lastName = "Knight";

            //Concatenation
            string concatenatedFullName = firstName + " " + lastName;

            //Composite 
            string compositeFullName = string.Format("{0} {1},", firstName, lastName);

            //Interpolation
            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);
            string stringExample;
        }

        [TestMethod]
        public void Collections()
        {
            //Array
            string stringExample = "Hello World!";
            string[] stringArray = { "Hello", "World!", "Why", "is it", "always", stringExample, "?" };
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);

            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            //Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("First string for our list.");
            listOfIntegers.Add(8675309);
            Console.WriteLine(listOfIntegers[0]);

            //Queues 
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first!");
            firstInFirstOut.Enqueue("I'm next!");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            var amount = firstInFirstOut.Count;
            Console.WriteLine(amount);

            //Dictionaries 
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(007, "Bond, James Bond");
            string value = keyAndValue[007];
            Console.WriteLine(value);

            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();
            Console.WriteLine(randomNumber);

        }
    }
}
