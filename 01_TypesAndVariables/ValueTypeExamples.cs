using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true;

            bool isDeclarationAndInitialized = false;
            isDeclarationAndInitialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbol = '@';
            char number = '1';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteMax = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;

            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);

        }

        enum PastryType { Cake =1 , Cupcake, Eclaire, Croissant, Klondike_Bar}
        [TestMethod]
        public void Enums()
        {
            PastryType myPastry = PastryType.Klondike_Bar;
            PastryType anotherOne = PastryType.Croissant;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(2020, 03, 17);
            DateTime test = new DateTime(1992, 04, 43);
            
        }
    }
}
