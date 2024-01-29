using System;

/// <summary>
/// Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    ///  Method that adds two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        // Check if matrices are either both 2D or both 3D and have the same size
        if ((rows != 2 && rows != 3) || rows != matrix2.GetLength(0) || columns != matrix2.GetLength(1))
        {
            // Return a matrix containing -1 for invalid matrices
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
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
