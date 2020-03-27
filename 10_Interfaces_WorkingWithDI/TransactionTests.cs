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
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(4000.32m));
            decimal expectedDebt = 9000.12m - 4001.32m;
            Assert.AreEqual(expectedDebt, _debt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var epayment = new ElectronicPayment(1.50m);
            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(epayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual(1.50m, secondTransaction.GetTransactionAmount());
        }
    }
}
