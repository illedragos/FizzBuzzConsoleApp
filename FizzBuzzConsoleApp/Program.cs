using System;

//Write a program that prints the numbers from 1 to 100.
//But for multiples of three print “Fizz” instead of the number
//and for the multiples of five print “Buzz”.
//For numbers which are multiples of both three and five print “FizzBuzz”."

namespace FizzBuzzConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            FizzBuzz1(100);
            Console.ForegroundColor = ConsoleColor.Blue;
            Fizzbuzz2(100);
            Console.ForegroundColor = ConsoleColor.Red;
            Fizzbuzz3(100);
        }

        private static void FizzBuzz1(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5== 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

        private static void Fizzbuzz2(int n)
        {
            for(int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                if(i % 5 == 0)
                {
                    Console.Write("Buzz");
                }

                if(i%3!=0 && i % 5 != 0)
                {
                    Console.Write(i);
                }
                Console.WriteLine();

            }
        }

        private static void Fizzbuzz3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str.Length == 0)
                {
                    str = i.ToString();
                }
                Console.WriteLine(str);
            }
        }

    }
}
