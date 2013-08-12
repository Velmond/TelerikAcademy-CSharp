//Задача №6
//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class IsFemale
{
    static void Main()
    {
        Console.Write("Are you female? (y or n) - ");
        char answer;
        bool isFemale = false;      //Приемам начална стойност на променливата isFemale - false
        bool errorDetect = char.TryParse(Console.ReadLine(), out answer);   
        while (errorDetect == false || ((answer != 'y' && answer != 'Y') && (answer != 'n' && answer != 'N')))
        {                                                                   //Правя валидация на входа, за да се повтори въпроса
            Console.WriteLine("This is an invalid input!");                 //в случай, че не се посочи някой от желаните отговори
            Console.Write("Are you female? (y or n) - ");                   //докато това не стане. По този начин избягвам 
            errorDetect = char.TryParse(Console.ReadLine(), out answer);    //"гръмване" на програмата.
        }
        if (answer == 'y' || answer == 'Y')
        {                       //Ако отговорът е "да" ('y' или 'Y') програмата дава на isFemale стойност true.
            isFemale = true;    //Ако отговорът не е "да" (но е 'n' или 'N') програмата използва първоначално
        }                       //зададената стойност на isFemale - false.
        Console.WriteLine("The statement \"You are female\" is {0}", isFemale);
    }
}