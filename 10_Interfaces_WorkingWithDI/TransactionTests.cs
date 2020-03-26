using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_WorkingWithDI
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;
        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} toards your debt");
        }
        [TestInitialize]
        public void Arrange()
        {
            _debt = 9000.12m;
        }
        [TestMethod]
        public void PayDebtTest()
        {

        }
    }
}
