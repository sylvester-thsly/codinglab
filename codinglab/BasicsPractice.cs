using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingLab.Basics
{
    /* 
       This class stores the fundamental C# drills completed on Dometrain.
       Goal: Build muscle memory for school and Year 1 at CargoNerds.
    */
    public class BasicsPractice
    {
        /* --- 1. Integers & Comments --- */
        
        /* This method adds two integers together. */
        public static int Calculate(int a, int b) => a + b;

        public static int GetAge() => 25;
        
        public static int AddNumbers(int a, int b) => a + b;

        /* --- 2. The Var Keyword --- */
        
        public static int DoubleValue(int value)
        {
            var result = value * 2;
            return result;
        }

        /* --- 3. Doubles & Decimals (Financial Precision) --- */

        public static double GetPi() => 3.14159;
        
        public static double GetBoilingPointFahrenheit() => 212.0;

        public static decimal AddPrices(decimal price1, decimal price2)
        {
            // Always use decimal.Add for financial accuracy!
            return decimal.Add(price1, price2);
        }

        /* --- 4. Strings & Escape Sequences --- */

        public static void PrintFormattedMessage()
        {
            Console.WriteLine("\"Welcome to C#!\""); 
            Console.WriteLine(); 
            Console.WriteLine("Path: C:\\Users\\Documents"); 
            Console.WriteLine("\tIndented with a tab"); 
        }

        /* --- 5. Verbatim Strings (@) --- */

        public static void PrintFilePaths()
        {
            Console.WriteLine(@"C:\Users\Admin\Documents\report.txt");
            Console.WriteLine(@"SELECT *
FROM Users
WHERE Active = 1");
        }

        /* --- 6. String Concatenation (+) --- */

        public static void PrintConcatenation(string firstName, string lastName, int age)
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old.");
        }

        /* --- 7. String Interpolation ($) --- */

        public static void PrintUserProfile(string name, int age, double height, decimal balance)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age} years old");
            Console.WriteLine($"Height: {height}m");
            Console.WriteLine($"Balance: ${balance:0.00}");
        }
        /* --- 8. Chars --- */

        public static void PrintCharInfo(char c)
        {
            Console.WriteLine(c);
            Console.WriteLine(char.IsLetter(c));
            Console.WriteLine(char.IsDigit(c));
            Console.WriteLine(char.IsUpper(c));
        }

        /* --- 9. Booleans --- */

        public static bool IsEligibleToVote(bool isAdult, bool isCitizen)
        {
            return isAdult && isCitizen;
        }

        /* --- 10. Operators --- */

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static int GetRemainder(int dividend, int divisor) => dividend % divisor;

        /* Order of Operations: parentheses force addition first */
        public static int Calculate(int a, int b, int c) => (a + b) * c;

        /* Compound Assignment */
        public static int ApplyAdditionAssignment(int value, int amount)
        {
            value += amount;
            return value;
        }

        /* Increment & Decrement */
        public static int PostIncrement(int value) => value++;
        public static int PreIncrement(int value) => ++value;
        public static int PostDecrement(int value) => value--;
        public static int PreDecrement(int value) => --value;
    }
}
