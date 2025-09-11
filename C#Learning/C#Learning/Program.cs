// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //TASK A

        // Task 1
        int[] numsArray = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };

        Console.Write("numsArray = ");
        for (int i = 0; i < numsArray.Length; i++)
        {
            int num = numsArray[i];

            if (i < numsArray.Length - 1)
            {
                Console.Write(num + ", ");
            } else
            {
                Console.WriteLine(num);
            }
        }

        // Task 2
        string[] months = new string[12] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "Jule",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        Console.WriteLine("months: ");

        foreach (string month in months)
        {
            Console.WriteLine(month);
        }

        // Task 3
        int[][] matrix = new int[3][] { new[] { 2, 3, 4 }, new[] { 4, 9, 16 }, new[] { 8, 27, 64 } };

        Console.WriteLine("matrix: ");

        for (int i = 0; i < matrix.Length; i++)
        {
            Console.Write(i + 1 + " matrixArray: ");
            for (int j = 0; j < matrix[i].Length; j++)
            {
                int num = matrix[i][j];

                if (j < matrix[i].Length - 1)
                {
                    Console.Write(num + ", ");
                } else
                {
                    Console.WriteLine(num);
                }
            }
        }

        // Task 4
        double[][] jaggedArray = new double[3][] {
            new[] { 1d, 2d, 3d, 4d, 5d},
            new[] { Math.E, Math.PI },
            new[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
        };

        Console.WriteLine("jaggedArray: ");

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write(i + 1 + " jaggedArray: ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                double num = jaggedArray[i][j];

                if (j < jaggedArray[i].Length - 1)
                {
                    Console.Write(num + ", ");
                } else
                {
                    Console.WriteLine(num);
                }
            }
        }

        //TASK B

        int[] array = { 1, 2, 3, 4, 5 };
        int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

        //TASK 5

        Array.Copy(array, array2, 3);

        Console.Write("Array2 = ");

        for (int i = 0; i < array2.Length; i++)
        {
            int num = array2[i];

            if (i < array2.Length - 1)
            {
                Console.Write(num + ", ");
            }
            else
            {
                Console.WriteLine(num);
            }
        }


        //TASK 6

        Array.Resize(ref array, array.Length * 2);

        Console.Write("Array = ");

        for (int i = 0; i < array.Length; i++)
        {
            int num = array[i];

            if (i < array.Length - 1)
            {
                Console.Write(num + ", ");
            }
            else
            {
                Console.WriteLine(num);
            }
        }


        Console.ReadKey();
    }
}