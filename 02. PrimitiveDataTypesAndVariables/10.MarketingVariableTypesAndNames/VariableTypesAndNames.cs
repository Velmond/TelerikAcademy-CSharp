//Задача №10
//A marketing firm wants to keep record of its employees. Each record would have the following characteristics –
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
//Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class VariableTypesAndNames
{
    static void Main()
    {
        string nameFirst = "Ivan";
        string nameLast = "Ivanov";
        byte age = 30;
        char gender = 'm';
        int numberID = 123456789;
        uint nimberEmployee = 27561234;
        Console.WriteLine("First name:\t{0} \nLast name:\t{1} \nAge:\t\t{2} \nGender:\t\t{3} \nID number:\t{4} \nUnique Number:\t{5}", nameFirst, nameLast, age, gender, numberID, nimberEmployee);
    }
}