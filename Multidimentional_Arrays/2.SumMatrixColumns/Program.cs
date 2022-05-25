﻿using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] colElements = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = colElements[k];
                }
            }

            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                int sum = 0;
                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sum += matrix[rows, cols];
                }
                Console.WriteLine(sum);
            }
        }
    }
}

