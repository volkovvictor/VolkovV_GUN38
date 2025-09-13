// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Task 1
        int[] numsArray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

        Console.Write("First 10 numbers of numsArray: ");

        for (int i = 0; i < 10; i++)
        {
            if (i == 9)
            {
                Console.WriteLine(numsArray[i]);
            } else
            {
                Console.Write(numsArray[i] + ", ");
            }
        }

        // Task 2

        Console.Write("Even numbers up to 20: ");

        for (int i = 2; i <= 20; i+=2)
        {
            if (i == 20)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.Write(i + ", ");
            }
        }

        // Task 3

        Console.WriteLine("Multiplication table from 1 to 5: ");
        for (int i = 0; i <= 5; i++)
        {
            if (i == 0)
            {
                Console.Write("  | ");

                for (int j = 1; j <= 5; j++)
                {
                    if (j == 5)
                    {
                        Console.WriteLine(j);
                    } else
                    {
                        Console.Write(j + " | ");
                    }
                }

                continue;
            }

            Console.Write(i + " | ");

            for (int k = 1; k <= 5; k++)
            {
                int mult = k * i;

                if (k == 5)
                {
                    Console.WriteLine(mult);
                }
                else
                {
                    Console.Write(mult + " | ");
                }
            }
        }

        // Task 4

        string password = "qwerty";
        string result;

        do {
           Console.WriteLine("Input a password");
           result = Console.ReadLine();

            if (result == password)
            {
                Console.WriteLine("Success!");
            }
            
        } while(result != password);

        Console.ReadKey();
    }
}