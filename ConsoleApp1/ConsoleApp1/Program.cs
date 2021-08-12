using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            int myInteger;
            string myString;
            myInteger = 114514;
            myString = "\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");
            Console.ReadKey();
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Input your name:");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");
            Console.WriteLine("Input a number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input another number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Sum {firstNumber} and {secondNumber}: " + $"{firstNumber + secondNumber}");
            Console.WriteLine($"Subtraction: " + $"{firstNumber - secondNumber}");
            Console.WriteLine($"Multiplication: " + $"{firstNumber * secondNumber}");
            Console.WriteLine($"Division: " + $"{firstNumber / secondNumber}");
            Console.WriteLine($"Remainder: " + $"{firstNumber % secondNumber}");
            Console.ReadKey();
        }
    }
}
