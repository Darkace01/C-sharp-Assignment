using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting 8 numbers from user and getting the average

            int sum = 0;

            Console.WriteLine("How many numbers do you want to get the average for?");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("input your number");
                int number = Convert.ToInt32(Console.ReadLine());
                sum = sum + number;
            }
            double total = (double) sum / n;
            Console.WriteLine("Your answer is " + total);
            factorial();
            Console.ReadLine();
            
        }
        static void factorial()
        {
            //Factorial

            int cob1;
            int cob2;
            int total;
            int factoriaA = 1;
            int factoriaB = 1;
            int i;



            Console.WriteLine("Input your first Number");
            cob1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your Secound Number");
            cob2 = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= cob1; i++)
            {
                factoriaA = factoriaA * i;
            }
            Console.WriteLine("The factorial of " + cob1 + " is " + factoriaA);

            for (i = 1; i <= cob2; i++)
            {
                factoriaB = factoriaB * i;
            }
            Console.WriteLine("The factorial of " + cob2 + " is " + factoriaB);
            total = factoriaA / (factoriaA - factoriaB) * factoriaB;
            Console.WriteLine("The Combination of " + cob1 + " and " + cob2 + " is " + total);
            oneThirty();
            Console.ReadLine();


        }
        static void oneThirty()
        {

            //Printing numbers from one to thirty
            int n = 30;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();



            //Print the square of numbers from one to 30
            int counter;

            int square = 30;
            const int maxValue = 30;



            Console.WriteLine("Number Square");
            Console.WriteLine("-------------");

            for (counter = 1; counter <= maxValue; counter++)
            {
                square = counter * counter;
                Console.WriteLine("{0}  {1}", counter, square);
                Console.WriteLine("-------------\n");
            }

            Console.WriteLine();

            //Check Prime number

            int num1;

            Console.WriteLine("What number do you want to check?");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 == 0 || num1 == 1)
            {
                Console.WriteLine(num1 + "is not a prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {

                    if (num1 % a == 0)
                    {
                        Console.WriteLine(num1 + " is not a prime number");
                        return;
                    }
                }
                Console.WriteLine(num1 + " is a prime number");

            }

            //Multiplication Table

            int amount = 12;
            int mult;
            Console.WriteLine("What multiplication table do you want?");
            int m = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < amount; i++)
            {
                mult = i * m;
                Console.WriteLine(mult);
            }
            fibonacci();
            Console.ReadLine();


        }
        static void fibonacci()
        {
            //Fibonacci Number
            int val1 = 0, val2 = 1, val3, i;

            Console.WriteLine("Input How many Fibonacci series you want to run");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1st ten Fibonacci numbers:");
            Console.Write(val1 + " " + val2 + " ");

            for (i = 2; i < n; i++)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}
