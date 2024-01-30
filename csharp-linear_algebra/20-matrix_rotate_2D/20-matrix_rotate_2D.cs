using System;

/// <summary>
/// Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    ///  Method that rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="angle"></param>
    /// <returns></returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != columns)
        {
            // Return a matrix containing -1 for invalid rotation
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Apply rotation formula to each element
                result[i, j] = matrix[i, j] * cosTheta - matrix[i, j] * sinTheta;
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
