using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            /* 1- Write a program that takes a number from the user then print yes if that
            number can be divided by 3 and 4 otherwise print no.
            Example (1)
            Input: 12
            Output: Yes
            Example (2)
            Input: 9
            Output: No
             */

            //Console.WriteLine("enter a number");
            //int num= int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion

            #region q2
            //2 - Write a program that allows the user to insert an integer then print
            //negative if it is negative number otherwise print positive.


            //Console.WriteLine("enter a number");
            //int num= int.Parse(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Positive");
            //}

            #endregion

            #region q3
            //3 - Write a program that takes 3 integers from the user then prints the max
            //element and the min element.
            //Console.WriteLine("enter 3 numbers");
            //int num1= int.Parse(Console.ReadLine());
            //int num2= int.Parse(Console.ReadLine());
            //int num3= int.Parse(Console.ReadLine());
            //if( num1> num2 && num1 > num3)
            //{
            //    Console.WriteLine("Max: " + num1);
            //}
            //else if (num2 > num1 && num2 > num3)
            //{
            //    Console.WriteLine("Max: " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("Max: " + num3);
            //}
            //if (num1 < num2 && num1 < num3)
            //{
            //    Console.WriteLine("min: " + num1);
            //}
            //else if (num2 < num1 && num2 < num3)
            //{
            //    Console.WriteLine("min: " + num2);
            //}
            //else
            //{
            //    Console.WriteLine("min: " + num3);
            //}
            #endregion

            #region q4
            //4 - Write a program that allows the user to insert an integer number then
            //check If a number is even or odd.

            //Console.WriteLine("enter a number");
            //int num= int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("even");
            //}
            //else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion

            #region q5
            //5 - Write a program that takes character from the user then if it is a vowel
            //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

            //Console.Write("Enter a character: ");
            //char c = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine("\n" + (new[] { 'a', 'e', 'i', 'o', 'u' }.Contains(c) ? "vowel" : "consonant"));

            #endregion

            #region q6
            //6 - Write a program that allows the user to insert an integer then print all
            //numbers between 1 to that number.

            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region q7

            //7 - Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.
            //Console.WriteLine("enter a number");
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 0; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num} * {i} = {num * i}");
            //}

            #endregion

            #region q8
            //8 - Write a program that allows to user to insert number then print all even
            //numbers between 1 to this number

            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region q9
            //9 - Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the exponent number: ");
            //int exponent = int.Parse(Console.ReadLine());
            //long res = 1;
            //for(int i=0;i< exponent; i++)
            //{
            //    res*= baseNum;
            //}
            //Console.WriteLine($"{baseNum} raised to the power of {exponent} is {res}");

            #endregion

            #region q10
            //10 - Write a program to enter marks of five subjects and calculate total,
            //average and percentage.
            //Console.Write("Enter marks of five subjects (separated by space): ");
            //int n1= int.Parse(Console.ReadLine());
            //int n2= int.Parse(Console.ReadLine());
            //int n3= int.Parse(Console.ReadLine());
            //int n4= int.Parse(Console.ReadLine());
            //int n5= int.Parse(Console.ReadLine());
            //int res=n1 + n2 + n3 + n4 + n5;
            //Console.WriteLine(res/5);


            #endregion

            #region q11

            //11 - Write a program to input the month number and print the number of days in
            //that month.
            //Console.Write("Enter the month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //int days = DateTime.DaysInMonth(DateTime.Now.Year, month);
            //Console.WriteLine($"Days in Month: {days}");


            #endregion

            #region q12
            // 12 - Write a program to create a Simple Calculator.
            //Console.WriteLine("Simple Calculator");
            //Console.WriteLine("Enter first number:");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter operator (+, -, *, /):");
            //char op = Console.ReadKey().KeyChar;
            //Console.WriteLine("Enter second number:");
            //double num2 = double.Parse(Console.ReadLine());

            //double result = 0;
            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        return;
            //}
            //Console.WriteLine($"Result: {result}");
            #endregion

            #region q13
            //13 - Write a program to allow the user to enter a string and print the REVERSE
            //  of it.
            //Console.Write("Enter a string: ");
            //string s = Console.ReadLine();
            //Console.WriteLine(new string(s.Reverse().ToArray()));

            #endregion

            #region q14
            //14 - Write a program to allow the user to enter int and print the REVERSED of
            // it.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //string reversed = number.ToString().Reverse().ToArray();
            #endregion

            #region q15
            //15 - Write a program in C# Sharp to find prime numbers within a range of
            //numbers.
            //Console.Write("Enter the range (start and end): ");
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i < end; i++)
            //{
            //    bool b = true;
            //    for(int j= 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;
            //        }
            //    }
            //    if(b && i > 1)
            //    {
            //        Console.WriteLine(i + " is a prime number.");
            //    }
            //}
            #endregion

            #region q16
            //16 - Create a program that asks the user to input three points(x1, y1), (x2,
            //y2), and(x3, y3), and determines whether these points lie on a single
            //straight line.
            //Console.Write("Enter x1 y1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x2 y2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter x3 y3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //double y3 = double.Parse(Console.ReadLine());

            //bool isStraight = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
            //Console.WriteLine(isStraight ? "Straight line" : "Not straight");
            
            #endregion

            #region q17

            //17 - Within a company, the efficiency of workers is evaluated based on the
            //duration required to complete a specific task.A worker's efficiency level is
            //determined as follows:
            //-If the worker completes the job within 2 to 3 hours, they are considered
            //highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their
            //speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to
            //enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the
            //company.
            //To calculate the efficiency of a worker, the time taken for the task is
            //obtained via user input from the keyboard.

            //Console.Write("Enter time taken (hours): ");
            //double hours = double.Parse(Console.ReadLine());
            //Console.WriteLine(hours switch
            //{
            //    <= 3 => "highly efficient",
            //    <= 4 => "increase speed",
            //    <= 5 => "needs training",
            //    _ => "leave company"
            //});
            #endregion
        }
    }
}
