using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_Intro
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();
            var output = banana.Peel();
            Console.WriteLine(output);
            Console.WriteLine("The banana is peeled: " + banana.Peeled);
            Assert.IsTrue(banana.Peeled);
        }
    }
}
