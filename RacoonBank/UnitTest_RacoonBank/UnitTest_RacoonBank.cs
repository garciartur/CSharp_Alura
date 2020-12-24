using _01_RacoonBank;
using _01_RacoonBank.Employees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_RacoonBank
{
    [TestClass]
    public class UnitTest_CheckingAccount
    {
        CheckingAccount checkingAccount_A, checkingAccount_B;

        [TestInitialize]
        public void Initializer()
        {
            checkingAccount_A = new CheckingAccount(87255, 512);
            checkingAccount_B = new CheckingAccount(52418, 881);
        }

        [TestMethod]
        public void TestWithdraw_WhenAccountBalanceIsLessThanAmount_ShouldReturnFalse()
        {
            //arrange
            double amount = 2 * checkingAccount_A.AccountBalance;

            //act
            bool ret = checkingAccount_A.Withdraw(amount);

            //assert
            Assert.IsFalse(ret);
        }

        [TestMethod]
        public void TestDeposit_ShouldReturnAccountBalancePlusAmount()
        {
            //arrange
            double amount = 2 * checkingAccount_A.AccountBalance;
            double initialAccountBalance = checkingAccount_A.AccountBalance;

            //act
            checkingAccount_A.Deposit(amount);
            bool ret = checkingAccount_A.AccountBalance == (initialAccountBalance + amount);

            //assert
            Assert.IsTrue(ret);
        }

        [TestMethod]
        public void TestTransfer_WhenAmountIsLessThanAccountBalance_ShouldReturnTrue()
        {
            //arrange
            double amount = checkingAccount_A.AccountBalance / 2;

            //act
            bool ret = checkingAccount_A.Transfer(amount, checkingAccount_B);

            //assert
            Assert.IsTrue(ret);
        }
    }

    [TestClass]
    public class UnitTest_Designer
    {
        Designer designer;

        [TestInitialize]
        public void Initializer()
        {
            designer = new Designer(2500, "481.963.574-14");
        }

        [TestMethod]
        public void TestIncreaseSalary_ShouldReturnEmpSalaryPlusElevenPercent()
        {
            //arrange
            double increasedSalary = designer.EmpSalary * 1.11;

            //act
            designer.increaseSalary();
            double ret = designer.EmpSalary;

            //assert
            Assert.AreEqual(ret, increasedSalary);
        }

        [TestMethod]
        public void TestGetBonus_ShouldReturnSeventeenPercentofEmpSalary()
        {
            //arrange
            double bonus = designer.EmpSalary * 0.17;

            //act     
            double ret = designer.GetBonus();

            //assert
            Assert.AreEqual(ret, bonus);
        }
    }
}
