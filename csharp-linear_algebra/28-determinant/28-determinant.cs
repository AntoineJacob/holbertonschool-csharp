using System;

/// <summary>
/// New matrix class calculation
/// </summary>
class MatrixMath
{
    /// <summary>
    /// New method for determinate the determinant of a matrix
    /// </summary>
    /// <param name="matrix">matrix gift in argument to the method</param>
    /// <returns>determinant of the matrix gift</returns>
    public static double Determinant(double[,] matrix)
    {
        double result = 0;

        if (matrix.GetLength(0) != matrix.GetLength(1) || matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 )
        {
            return -1;
        }

        if (matrix.GetLength(0) == 2)
        {
            result += (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        else
        {
            result += (matrix[0, 0] * matrix[1, 1] * matrix[2, 2]) + (matrix[0, 1] * matrix[1, 2] * matrix[2, 0]) + (matrix[0, 2] * matrix[1, 0] * matrix[2, 1]) - (matrix[0, 2] * matrix[1, 1] * matrix[2, 0]) - (matrix[0, 1] * matrix[1, 0] * matrix[2, 2]) - (matrix[0, 0] * matrix[1, 2] * matrix[2, 1]);
        }
        return Math.Round(result, 2);
    }
}