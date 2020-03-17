using System;
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
        }
    }
}
