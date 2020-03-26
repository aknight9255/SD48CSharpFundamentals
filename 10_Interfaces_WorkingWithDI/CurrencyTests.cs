using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_WorkingWithDI
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void DollarTest()
        {
            ICurrency dollar = new Dollar();
            Assert.AreEqual(1m, dollar.Value);
        }

        [DataTestMethod]
        [DataRow(12341.23)]
        [DataRow(32.44)]
        [DataRow(42.77)]
        [DataRow(432)]
        public void EPaymentTests(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);
            var ePayment = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePayment.Value);
        }

    }
}
