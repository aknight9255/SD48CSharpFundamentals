using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class OperatorExamples
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 42;
            int b = 23;

            int sum = a + b;
            Console.WriteLine(sum);

            int difference = a - b;
            Console.WriteLine(difference);

            int product = a * b;
            Console.WriteLine(product);

            int quotient = a / b;
            Console.WriteLine(quotient);

            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1942, 1, 1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);
        }

        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 654;
            string username = "Loki";

            bool equals = age == 42;
            bool userIsAdam = username == "Adam";
            Console.WriteLine("User is 42:" + equals );
            Console.WriteLine("The user is Adam" + userIsAdam);

            bool notEqual = age != 42;
            bool userIsNotAdam = username != "Adam";
            Console.WriteLine(notEqual);
            Console.WriteLine(userIsNotAdam);

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The lists are the same? {listAreEqual}");

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 24;
            bool lessThan = age < 89;
            bool lessThanOrEqual = age <= 24;

            bool orValue = equals || lessThan;

            bool andValue = greaterThan && orValue;

        }

    }
}
