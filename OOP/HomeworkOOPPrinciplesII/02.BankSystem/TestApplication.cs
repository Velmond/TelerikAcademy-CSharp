//02.  A bank holds different types of accounts for its customers: deposit accounts, loan accounts and
//    mortgage accounts. Customers could be individuals or companies.
//     All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed
//    to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//     All accounts can calculate their interest amount for a given period (in months). In the common case
//    its is calculated as follows: number_of_months * interest_rate.
//     Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2
//    months if are held by a company.
//     Deposit accounts have no interest if their balance is positive and less than 1000.
//     Mortgage accounts have 1/2 interest for the first 12 months for companies and no interest for the first
//    6 months for individuals.
//     Your task is to write a program to model the bank system by classes and interfaces. You should identify
//    the classes, interfaces, base classes and abstract actions and implement the calculation of the interest
//    functionality through overridden methods.

namespace BankSystem
{
    using System;

    class TestApplication
    {
        // See the unit tests in 02.02.BankSystemTests for more tests

        static void Main()
        {
            Customer individual = new Individual("Ivan", "Ivanov");
            Customer corporate = new Corporate("Ivanov Stroi", "Ltd");

            Account[] accounts = {
                                     new Deposit(individual, 900, 1.2m),
                                     new Deposit(individual, 10000, 1.2m),
                                     new Deposit(corporate, 150000, 1.5m),
                                     new Loan(individual, 10000, 3.5m),
                                     new Loan(corporate, 100000, 4.5m),
                                     new Mortgage(individual, 25000, 3.66m),
                                     new Mortgage(corporate, 125000, 4.25m),
                                 };

            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.AccountHolder);
                Console.WriteLine(acc);
                Console.WriteLine(acc.InterestAmount(2) + "%");
                Console.WriteLine(acc.InterestAmount(4) + "%");
                Console.WriteLine(acc.InterestAmount(6) + "%");
                Console.WriteLine(acc.InterestAmount(8) + "%");
                Console.WriteLine(acc.InterestAmount(10) + "%");
                Console.WriteLine(acc.InterestAmount(12) + "%");
                Console.WriteLine(acc.InterestAmount(18) + "%");
                Console.WriteLine(acc.InterestAmount(24) + "%");
            }
        }
    }
}