using System;

/// <summary>
/// New matrix class calculation
/// </summary>
class MatrixMath
{
    /// <summary>
    /// New method for transpose a matrix
    /// </summary>
    /// <param name="matrix">matrix gift in argument to the method</param>
    /// <returns>new matrix transposed</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] result = new double[matrix.GetLength(1), matrix.GetLength(0)];
        double[,] error = new double[0,0];

        if (matrix.GetLength(0) < 1)
        {
            return error;
        }
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] += matrix[j, i];
            }
        }
        return result;
    }
}