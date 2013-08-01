//Задача №3
//A company has name, address, phone number, fax number, web site and manager.
//The manager has first name, last name, age and a phone number. Write a program that
//reads the information about a company and its manager and prints them on the console.

using System;

class CompanyAndManagerInfo
{
    static void Main()
    {
        Console.Write("Input company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Input company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Input company phone number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Input company fax number: ");
        string companyFax = Console.ReadLine();
        Console.Write("Input company website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Input company manager's first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Input company manager's last name: ");
        string managerLastName = Console.ReadLine();
        object companyManager = managerFirstName + " " + managerLastName;
        Console.Write("Input company manager's age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Input company manager's phone number: ");
        string managerPhone = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Company name:\t{0}\nAddress:\t{1}\nPhone number:\t{2}\nFax number:\t{3}\nWebsite:\t{4}\n" +
                          "Company manager:\t{5}\nManager's age:\t\t{6}\nManager's phone number:\t{7}\n", companyName,
                          companyAddress, companyPhone, companyFax, companyWebsite, companyManager, managerAge, managerPhone);
    }
}