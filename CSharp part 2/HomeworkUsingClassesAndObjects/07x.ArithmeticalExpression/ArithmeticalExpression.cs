//07. *Write a program that calculates the value of given arithmetical expression. The expression can contain the following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities)
//Examples: (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7) -> ~ 10.6
//          pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) -> ~ 21.22
//Hint:     Use the classical "shunting yard" algorithm and "reverse Polish notation".

//!!!!!
//I made the program to works with sin(x), cos(x) and tan(x) also. 
//There are hard-coded examples in the Main method. If you want to use them you have to uncomment them

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExpressionCalculator
{
    public class ArithmeticalExpression
    {
        public static List<char> operations = new List<char>() { '+', '-', '*', '/', '(', };
        public static List<char> numberChars = new List<char>() { '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
        public static List<string> functions = new List<string>() { "ln", "pow", "sqrt", "sin", "cos", "tan", };

        public static Queue RPN(string equation)
        {
            Stack operators = new Stack();
            Queue output = new Queue();
            string function = "";
            string number = "";
            bool negativeNumber = false;
            int bracketCounter = 0;

            for (int i = 0; i < equation.Length; i++)
            {
                if ((operators.Count > 0 && equation[i] == '-' && equation[i - 1] == '(' && i > 0) || (i == 0 && equation[i] == '-'))
                    negativeNumber = true;                      //Checking if a number is negative

                if (negativeNumber)
                    i++;

                if (operations.Contains(equation[i]))
                {
                    if (operators.Count > 0 && (equation[i] == '-' || equation[i] == '+') && (operators.Peek().ToString() == "/" ||
                        operators.Peek().ToString() == "*"))
                    {
                        output.Enqueue(operators.Pop());
                        operators.Push(equation[i]);
                    }
                    else if (operators.Count > 0 && operators.Peek().ToString() == "-" && equation[i] == '+')
                    {
                        output.Enqueue(operators.Pop());
                        operators.Push(equation[i]);
                    }
                    else
                        operators.Push(equation[i]);
                }
                else if (equation[i] == ')')
                {
                    while (operators.Count != 0 && operators.Peek().ToString() != "(")
                    {                                               //If a closing bracket is found, all the operators after the last
                        if (operators.Peek().ToString() == "(")     //opening brecker are stuck to the output queue
                            break;

                        output.Enqueue(operators.Pop());
                    }

                    if (operators.Count != 0)
                        operators.Pop();
                }
                else if (!numberChars.Contains(equation[i]))
                {
                    while (!functions.Contains(function))
                    {
                        function += equation[i];
                        i++;
                    }

                    if (equation[i] == '(')
                    {
                        bracketCounter++;
                        i++;
                    }

                    if (equation[i] == '-')
                    {
                        number += '-';
                        i++;
                    }

                    while (bracketCounter != 0)
                    {
                        number += equation[i];
                        i++;

                        if (equation[i] == '(')
                            bracketCounter++;
                        else if (equation[i] == ')')
                            bracketCounter--;

                        if (bracketCounter == 1 && equation[i] == ',' && function == "pow")
                        {
                            if (!IsNumber(number))
                                output.Enqueue(Calculate(RPN(number))); //<- Recursion for directly calculating the value of an embedded
                            else                                        //function -> Example: For sin(1.2+22*sqrt(10)), at this point
                                output.Enqueue(number);                 //(1.2+22*sqrt(10)) will be calculated befor continuing the 
                                                                        //solution as if it was sin(70.77) from the start
                            number = "";
                            i++;

                            if (equation[i] == '-')
                            {
                                number += '-';
                                i++;
                            }

                            while (bracketCounter != 0)
                            {
                                number += equation[i];
                                i++;

                                if (equation[i] == '(')
                                    bracketCounter++;
                                else if (equation[i] == ')')
                                    bracketCounter--;
                            }
                        }
                    }

                    if (!IsNumber(number))
                        output.Enqueue(Calculate(RPN(number)));     //<- The same recursion as above
                    else
                        output.Enqueue(number);

                    output.Enqueue(function);
                    number = "";
                    function = "";
                }
                else if (numberChars.Contains(equation[i]))
                {
                    if (negativeNumber)
                        number += "-";

                    while (numberChars.Contains(equation[i]))
                    {
                        number += equation[i];
                        i++;

                        if (i == equation.Length)
                            break;
                    }

                    if (i <= equation.Length)
                    {
                        i--;
                        output.Enqueue(number);
                        number = "";
                        negativeNumber = false;
                    }
                }
            }

            int leftToAdd = operators.Count;    //If any elements are left in the operators stack, they are moved to the output queue

            for (int i = 0; i < leftToAdd - 1; i++)
                output.Enqueue(operators.Pop());

            if (operators.Count == 1 && operators.Peek().ToString() != "(")
                output.Enqueue(operators.Pop());

            return output;
        }

        public static decimal Calculate(Queue equationRPN)
        {
            Stack toDoStack = new Stack();
            decimal result = 0;
            bool firstNumberExists = false;
            bool secondNumberExists = false;
            decimal firstNumber = 0;
            decimal secondNumber = 0;

            while (equationRPN.Count != 1 || toDoStack.Count != 0)  //The calculations continue untill only one element is left -
            {                                                       //the finale result
                if (!firstNumberExists && decimal.TryParse(equationRPN.Peek().ToString(), out firstNumber))
                {
                    firstNumberExists = true;
                    toDoStack.Push(equationRPN.Dequeue());
                }
                else if (firstNumberExists && !secondNumberExists && decimal.TryParse(equationRPN.Peek().ToString(), out secondNumber))
                {
                    secondNumberExists = true;
                    toDoStack.Push(equationRPN.Dequeue());
                }
                else if (firstNumberExists && secondNumberExists && IsNumber(equationRPN.Peek().ToString()))
                {
                    firstNumber = decimal.Parse(toDoStack.Pop().ToString());
                    equationRPN.Enqueue(toDoStack.Pop());
                    toDoStack.Push(firstNumber);
                    toDoStack.Push(equationRPN.Dequeue());
                }
                else if (functions.Contains(equationRPN.Peek().ToString()))
                {
                    if (equationRPN.Peek().ToString() == "pow")
                    {
                        double power = double.Parse(toDoStack.Pop().ToString());
                        equationRPN.Enqueue((decimal)Math.Pow(double.Parse(toDoStack.Pop().ToString()), power));
                        equationRPN.Dequeue();
                    }
                    else if (equationRPN.Peek().ToString() == "ln")
                    {
                        equationRPN.Enqueue((decimal)Math.Log(double.Parse(toDoStack.Pop().ToString())));
                        equationRPN.Dequeue();

                        if (firstNumberExists && secondNumberExists)
                            equationRPN.Enqueue(toDoStack.Pop()); 
                    }
                    else if (equationRPN.Peek().ToString() == "sqrt")
                    {
                        equationRPN.Enqueue((decimal)Math.Sqrt(double.Parse(toDoStack.Pop().ToString())));
                        equationRPN.Dequeue();

                        if (firstNumberExists && secondNumberExists)
                            equationRPN.Enqueue(toDoStack.Pop());
                    }
                    else if (equationRPN.Peek().ToString() == "sin")
                    {
                        equationRPN.Enqueue((decimal)Math.Sin(Math.PI * double.Parse(toDoStack.Pop().ToString()) / 180));
                        equationRPN.Dequeue();

                        if (firstNumberExists && secondNumberExists)
                            equationRPN.Enqueue(toDoStack.Pop());
                    }
                    else if (equationRPN.Peek().ToString() == "cos")
                    {
                        equationRPN.Enqueue((decimal)Math.Cos(Math.PI * double.Parse(toDoStack.Pop().ToString()) / 180));
                        equationRPN.Dequeue();

                        if (firstNumberExists && secondNumberExists)
                            equationRPN.Enqueue(toDoStack.Pop());
                    }
                    else if (equationRPN.Peek().ToString() == "tan")
                    {
                        equationRPN.Enqueue((decimal)Math.Tan(Math.PI * double.Parse(toDoStack.Pop().ToString()) / 180));
                        equationRPN.Dequeue();

                        if (firstNumberExists && secondNumberExists)
                            equationRPN.Enqueue(toDoStack.Pop());
                    }

                    firstNumberExists = false;
                    secondNumberExists = false;
                }
                else if (firstNumberExists && secondNumberExists && operations.Contains((char)equationRPN.Peek()))
                {
                    if (equationRPN.Peek().ToString() == "+")
                        equationRPN.Enqueue(decimal.Parse(toDoStack.Pop().ToString()) + decimal.Parse(toDoStack.Pop().ToString()));
                    else if (equationRPN.Peek().ToString() == "-")
                        equationRPN.Enqueue(-decimal.Parse(toDoStack.Pop().ToString()) + decimal.Parse(toDoStack.Pop().ToString()));
                    else if (equationRPN.Peek().ToString() == "*")
                        equationRPN.Enqueue(decimal.Parse(toDoStack.Pop().ToString()) * decimal.Parse(toDoStack.Pop().ToString()));
                    else if (equationRPN.Peek().ToString() == "/")
                        equationRPN.Enqueue(1 / (decimal.Parse(toDoStack.Pop().ToString()) / decimal.Parse(toDoStack.Pop().ToString())));

                    firstNumberExists = false;
                    secondNumberExists = false;
                    equationRPN.Dequeue();
                }
                else if ((!firstNumberExists || !secondNumberExists) && !IsNumber(equationRPN.Peek().ToString()) &&
                          operations.Contains((char)equationRPN.Peek()))
                {
                    if (firstNumberExists)
                    {
                        equationRPN.Enqueue(toDoStack.Pop());
                        firstNumberExists = false;
                    }
                    equationRPN.Enqueue(equationRPN.Dequeue());
                }
            }

            result = decimal.Parse(equationRPN.Peek().ToString());

            return result;
        }

        private static bool IsNumber(object value)
        {
            decimal number;

            return decimal.TryParse(value.ToString(), out number);
        }

        static void Main()
        {
                    //!!!!!
                  //To use the hard-coded examples first and than enter your own delete the " /* " at the start of this row

            string[] equations = new string[] {
                "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)",                                      //Result: 10.6
                "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)",                           //Result: 21.22
                "(-2*2+cos(22.5)-pow(2,3.1))/(2.2-1.2*tan(35))",                                //Result: -8.57
                "tan(18+2*pow(3,3.14)/22)/sin(1.2+22*sqrt(10))",                                //Result: 0.40
                "ln(pow(sin(tan((14.5*5/12)/(90-3*45))+sqrt(pow(20,3))),sqrt(12*3/(6+2))))",    //Result: -1.0119e-04
            };
            for (int i = 0; i < equations.Length; i++)
            {
                Console.WriteLine(equations[i]);
                int accuracy = 0;
                while ((int)(Calculate(RPN(equations[i].ToLower().Replace(" ", string.Empty))) * (decimal)Math.Pow(10, accuracy)) == 0)
                    accuracy++;
                Console.Write("\nResult: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (accuracy == 0)
                    Console.WriteLine("{0:f2}", Calculate(RPN(equations[i].ToLower().Replace(" ", string.Empty))));
                else if (accuracy > 0 && accuracy <= 2)
                    Console.WriteLine("{0:f4}", Calculate(RPN(equations[i].ToLower().Replace(" ", string.Empty))));
                else
                    Console.WriteLine("{0:#.####e+00}", Calculate(RPN(equations[i].ToLower().Replace(" ", string.Empty))));
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine();
            }        
            //*/

            while (true)
            {
                Console.Title = "Expression calculator";
                Console.Write("Input the expression to calculate (or type \"");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("exit");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("\" to stop the program)\n->");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string equation = Console.ReadLine().ToLower().Replace(" ", string.Empty);
                Console.ForegroundColor = ConsoleColor.Gray;

                if (equation == "exit")
                {
                    Console.Clear();
                    string thankYou = "Thank you for using the Expression calculator!";
                    Console.SetCursorPosition((Console.WindowWidth - thankYou.Length) / 2, Console.WindowHeight / 2);
                    Console.WriteLine(thankYou);
                    Console.SetCursorPosition(0, Console.WindowHeight - 1);
                    break;
                }

                bool isInputCorrect = true;
                int openBrackets = 0, closeBrackets = 0;

                for (int i = 0; i < equation.Length; i++)
                    if (equation[i] == '(')
                        openBrackets++;
                    else if (equation[i] == ')')
                        closeBrackets++;

                if (openBrackets != closeBrackets)
                    isInputCorrect = false;

                if (isInputCorrect)
                {
                    Queue equationRPN = RPN(equation);      //Transforming the inout equation using the reverse Polish notation

                    //Console.Write("\nReverse Polish Notation: ");     //<- To see the reverse Polish notation
                    //Console.ForegroundColor = ConsoleColor.Yellow;
                    //object[] RPNarray = equationRPN.ToArray();
                    //for (int i = 0; i < RPNarray.Length; i++)
                    //{
                    //    Console.Write("{0}", RPNarray[i]);
                    //}
                    //Console.WriteLine();
                    //Console.ForegroundColor = ConsoleColor.Gray;

                    decimal result = Calculate(equationRPN);            //Calculating the result using the Calculate method

                    int accuracy = 0;                                   //Down from here it's all for the output
                    while ((int)(result * (decimal)Math.Pow(10, accuracy)) == 0)
                        accuracy++;

                    Console.Write("\nResult: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    if (accuracy == 0)
                        Console.WriteLine("{0:f2}", result);
                    else if (accuracy > 0 && accuracy <= 2)
                        Console.WriteLine("{0:f4}", result);
                    else
                        Console.WriteLine("{0:#.####e+00}", result);

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else                                                //If the number of opening and closing brackets don't match
                    Console.WriteLine("Incorect input! The number of opening and closing brackets doesn't match.");

                Console.WriteLine();
            }
            /**/
        }
    }
}