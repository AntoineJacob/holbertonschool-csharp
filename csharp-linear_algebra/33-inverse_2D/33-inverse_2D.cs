﻿using System;

/// <summary>
/// New matrix class calculation
/// </summary>
class MatrixMath
{
    /// <summary>
    /// New method for inverse a 2D matrix
    /// </summary>
    /// <param name="matrix">matrix gift in argument to the method</param>
    /// <returns>inverse of the matrix gift</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] error = new double[1, 1] { { -1 } };
        double[,] matrixInverse = new double[2, 2];

        if (matrix.GetLength(1) < 2 || matrix.GetLength(1) > 2)
        {
            return error;
        }

        double determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        if (determinant == 0)
        {
            return error;
        }
        matrixInverse[0, 0] = Math.Round(matrix[1, 1] / determinant, 2);
        matrixInverse[0, 1] = Math.Round(-matrix[0, 1] / determinant, 2);
        matrixInverse[1, 0] = Math.Round(-matrix[1, 0] / determinant, 2);
        matrixInverse[1, 1] = Math.Round(matrix[0, 0] / determinant, 2);

        return matrixInverse;
    }
}