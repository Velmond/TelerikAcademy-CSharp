namespace BankSystemTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BankSystem;

    [TestClass]
    public class BankSystemTests
    {
        [TestMethod]
        public void IndividualDepositUnder1000Test()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Account account = new Deposit(individual, 900, 1.2m);

            for (uint i = 1; i <= 24; i++)
            {
                Assert.AreEqual(0m, account.InterestAmount(i));
            }
        }

        [TestMethod]
        public void IndividualDepositOver1000Test()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Account account = new Deposit(individual, 1001, 1.2m);

            for (uint i = 1; i <= 24; i++)
            {
                Assert.AreEqual(i * account.InterestRate, account.InterestAmount(i));
            }
        }

        [TestMethod]
        public void CorporateDepositUnder1000Test()
        {
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");
            Account account = new Deposit(corporate, 900, 1.2m);

            for (uint i = 1; i <= 24; i++)
            {
                Assert.AreEqual(0m, account.InterestAmount(i));
            }
        }

        [TestMethod]
        public void CorporateDepositOver1000Test()
        {
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");
            Account account = new Deposit(corporate, 100000, 1.2m);

            for (uint i = 1; i <= 24; i++)
            {
                Assert.AreEqual(i * account.InterestRate, account.InterestAmount(i));
            }
        }

        [TestMethod]
        public void IndividualLoanTest()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Account account = new Loan(individual, 10000, 3.5m);

            for (uint i = 1; i <= 24; i++)
            {
                if (i <= 3)
                {
                    Assert.AreEqual(0m, account.InterestAmount(i));
                }
                else
                {
                    Assert.AreEqual((i - 3) * account.InterestRate, account.InterestAmount(i));
                }
            }
        }

        [TestMethod]
        public void CorporateLoanTest()
        {
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");
            Account account = new Loan(corporate, 100000, 1.2m);

            for (uint i = 1; i <= 24; i++)
            {
                if (i <= 2)
                {
                    Assert.AreEqual(0m, account.InterestAmount(i));
                }
                else
                {
                    Assert.AreEqual((i - 2) * account.InterestRate, account.InterestAmount(i));
                }
            }
        }

        [TestMethod]
        public void IndividualMortgageTest()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Account account = new Mortgage(individual, 10000, 3.5m);

            for (uint i = 1; i <= 24; i++)
            {
                if (i <= 6)
                {
                    Assert.AreEqual(0m, account.InterestAmount(i));
                }
                else
                {
                    Assert.AreEqual((i - 6) * account.InterestRate, account.InterestAmount(i));
                }
            }
        }

        [TestMethod]
        public void CorporateMortgageTest()
        {
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");
            Account account = new Mortgage(corporate, 100000, 1.2m);

            for (uint i = 1; i <= 24; i++)
            {
                if (i <= 12)
                {
                    Assert.AreEqual((i * account.InterestRate) * 0.5m, account.InterestAmount(i));
                }
                else
                {
                    Assert.AreEqual((i - 6) * account.InterestRate, account.InterestAmount(i));
                }
            }
        }

        [TestMethod]
        public void DepositInAccountTest()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");

            Account[] accounts = {
                                     new Deposit(individual, 100000, 1.2m),
                                     new Deposit(corporate, 100000, 1.2m),
                                     new Loan(individual, 100000, 1.2m),
                                     new Loan(corporate, 100000, 1.2m),
                                     new Mortgage(individual, 100000, 1.2m),
                                     new Mortgage(corporate, 100000, 1.2m),
                                 };

            foreach (var acc in accounts)
            {
                Assert.AreEqual(100000m, acc.Balance);
                acc.Deposit(1000);
                Assert.AreEqual(101000m, acc.Balance);

                try
                {
                    acc.Deposit(-1);
                }
                catch (Exception e)
                {
                    Assert.AreEqual("Deposited amount must be a positive number.", e.Message);
                }
            }
        }

        [TestMethod]
        public void WithdrawFromAccountTest()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");

            Deposit[] accounts = {
                                     new Deposit(individual, 100000, 1.2m),
                                     new Deposit(corporate, 100000, 1.2m),
                                 };

            foreach (var acc in accounts)
            {
                Assert.AreEqual(100000m, acc.Balance);
                acc.Withdraw(1000);
                Assert.AreEqual(99000m, acc.Balance);

                try
                {
                    acc.Withdraw(99001);
                }
                catch (Exception e)
                {
                    Assert.AreEqual("You can't withdraw more than you have in your balance.", e.Message);
                }
            }
        }
    }
}