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
            designer = new Designer(2500, "576.102.040-80");
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

    [TestClass]
    public class UnitTest_Assistant
    {
        Assistant assistant;

        [TestInitialize]
        public void Initializer()
        {
            assistant = new Assistant(1500, "569.388.690-57");
        }

        [TestMethod]
        public void TestIncreaseSalary_ShouldReturnEmpSalaryPlusTenPercent()
        {
            //arrange
            double increasedSalary = assistant.EmpSalary * 1.1;

            //act
            assistant.increaseSalary();
            double ret = assistant.EmpSalary;

            //assert
            Assert.AreEqual(ret, increasedSalary);
        }

        [TestMethod]
        public void TestGetBonus_ShouldReturnTwentyPercentofEmpSalary()
        {
            //arrange
            double bonus =  assistant.EmpSalary * 0.2;

            //act     
            double ret = assistant.GetBonus();

            //assert
            Assert.AreEqual(ret, bonus);
        }
    }

    [TestClass]
    public class UnitTest_Developer
    {
        Developer developer;

        [TestInitialize]
        public void Initializer()
        {
            developer = new Developer(3650, "563.373.980-92");
        }

        [TestMethod]
        public void TestIncreaseSalary_ShouldReturnEmpSalaryPlusFifteenPercent()
        {
            //arrange
            double increasedSalary = developer.EmpSalary * 1.15;

            //act
            developer.increaseSalary();
            double ret = developer.EmpSalary;

            //assert
            Assert.AreEqual(ret, increasedSalary);
        }

        [TestMethod]
        public void TestGetBonus_ShouldReturnTenPercentofEmpSalary()
        {
            //arrange
            double bonus = developer.EmpSalary * 0.1;

            //act     
            double ret = developer.GetBonus();

            //assert
            Assert.AreEqual(ret, bonus);
        }
    }
}
