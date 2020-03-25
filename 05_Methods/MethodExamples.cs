using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            var sum = numOne + numTwo;
            return sum;
        }
        public double AddTwoNumbers(double numOne, double numTwo) => numOne + numTwo;
        //{
        //    double sum = numOne + numTwo;
        //    return sum;
        //}

     

        private int CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }

        [TestMethod]
        public void MethodExecution()
        {
            SayHello("Banana");
            SayHello("Bob");
            var sum = AddTwoNumbers(42, 75);
            Console.WriteLine(sum);

            var doubleSum = AddTwoNumbers(12.2, 43.6);

            int myAge = CalculateAge(new DateTime(1901, 05, 23));
            Console.WriteLine("My age: " + myAge);
            
        }
    }

    public class TestClass
    {
        MethodExamples aVar = new MethodExamples();
        
    }
}
