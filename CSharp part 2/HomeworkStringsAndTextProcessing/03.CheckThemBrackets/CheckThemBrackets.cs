//03. Write a program to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d).
//    Example of incorrect expression: )(a+b)).

namespace CheckThemBrackets
{
    using System;

    class CheckThemBrackets
    {
        static void Main()
        {
            Console.Write("Input the expression which's brackets you need checked: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string expression = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;

            int bracketCount = 0;

            for (int i = 0; i < expression.Length; i++) //Count all the brackets
            {
                if (expression[i] == '(')
                {
                    bracketCount++;
                }
                else if (expression[i] == ')')
                {
                    bracketCount--;
                }

                if (bracketCount < 0)       //If at some point the count of the brackets are less than 0 that means that
                {                           //...at some point the closing brackets are more than the opening ones so we 
                    break;                  //...break out of the loop
                }
            }

            bool isCorrect = true;

            if (bracketCount != 0)          //If the count is different than 0 that means that the expression is incorrect
            {
                isCorrect = false;
            }

            string isOrIsNot = string.Empty;

            if (isCorrect)
            {
                isOrIsNot = "IS";
            }
            else
            {
                isOrIsNot = "is NOT";
            }

            Console.Write("The expression {0} ", expression);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(isOrIsNot);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(" correct (as far as brackets are conserned).");
        }
    }
}
