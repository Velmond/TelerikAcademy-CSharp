//Задача №14
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed to
//keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanovski";
        string holderName = firstName + " " + middleName + " " + lastName;
        string bankName = "DSK";
        string IBAN = "BGGB 123456789012345678";
        string BIC = "BGGB EFFE";
        string creditCard1 = "1234123412341234";    //За номерата на кредитните карти избрах да са тип string, защото с тях няма
        string creditCard2 = "5678567856785678";    //да се извършват никакви математически операции. 
        string creditCard3 = "1234567812345678";    //За баланса на сметката съм избрал тип decimal, за максимална точност.
        decimal balance = 999999.99m;
        Console.WriteLine("Holder's name: \t{0}\nBank name: \t{1}\nIBAN: \t\t{2}\nBIC: \t\t{3}\n" +
                          "Credit card #1: {4}\nCredit card #2: {5}\nCredit card #3: {6}\n" +
                          "Balance: \t{7:F2}", holderName, bankName, IBAN, BIC, creditCard1, creditCard2, creditCard3, balance);
    }
}