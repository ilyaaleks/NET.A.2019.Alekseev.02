using System;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Task1()
        {
            int numberSource, numberin, i, j;
            Console.WriteLine("Enter the numbers (first number, second number, start bit, end bit) separated by spaces: ");
            string data = Console.ReadLine();
            string[] numbers = data.Split(" ");
            numberSource = Convert.ToInt32(numbers[0]);
            numberin = Convert.ToInt32(numbers[1]);
            i = Convert.ToInt32(numbers[2]);
            j = Convert.ToInt32(numbers[3]);
            Tasks.InsertNumber(numberSource, numberin, i, j);
        }
        static void Task3()
        {
            Console.WriteLine("Insert the number: ");
            string str = Console.ReadLine();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Tasks.FindNextBiggerNumber(str);
            stopwatch.Stop();
            Console.WriteLine($"Runtime in ms: " + stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
        static void Task4()
        {
            Console.WriteLine("Enter the number: ");
            char digit = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter numbers with a space: ");
            string str = Console.ReadLine();
            string[] strings = str.Split(" ");
            Tasks.FilterDigit(digit, strings);
        }
        static void Task5()
        {
            Console.WriteLine("Enter the root, number, precision after a space: ");
            string str = Console.ReadLine();
            String[] strmas = str.Split(" ");
            uint n = Convert.ToUInt32(strmas[0]);
            double a = Convert.ToDouble(strmas[1]);
            double eps = Convert.ToDouble(strmas[2]);
            Tasks.FindNthRoot(a, n, eps);
        }
        static void Main(string[] args)
        {
            ///<summary>This is the main method for selecting a task</summary>
            bool flag = true;
            int choiсe = 0;
            while(flag)
            {
                Console.WriteLine("Enter the task number: ");
                choiсe = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if(choiсe==1)
                {
                    Task1();
                }
                else if(choiсe==2)
                {
                    Console.WriteLine("Insert the number: ");
                    Tasks.FindNextBiggerNumber(Console.ReadLine());
                }
                else if(choiсe==3)
                {
                    Task3();
                }
                else if(choiсe==4)
                {
                    Task4();
                }
                else if(choiсe==5)
                {
                    Task5();
                }
            }
        }
    }
}
