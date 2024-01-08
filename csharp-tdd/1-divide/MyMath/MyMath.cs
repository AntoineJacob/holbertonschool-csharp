﻿using System;

namespace MyMath
{
    /// <summary>
    /// public class Matrix
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// public static int[,] Divide(int[,] matrix, int num)
        /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            else if (matrix == null)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = matrix[i, j] / num;
                    }
                }
                return matrix;
            }
        }
    }
}