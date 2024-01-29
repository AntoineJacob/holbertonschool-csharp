using System;

/// <summary>
/// Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns></returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is either 2D or 3D
        if ((rows != 2 && rows != 3) || rows != columns)
        {
            // Return a matrix containing -1 for invalid matrix
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }

    public static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
