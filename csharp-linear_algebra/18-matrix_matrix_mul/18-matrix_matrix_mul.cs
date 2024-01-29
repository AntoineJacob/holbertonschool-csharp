using System;

/// <summary>
/// Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int columns1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int columns2 = matrix2.GetLength(1);

        // Check if matrices can be multiplied
        if (columns1 != rows2)
        {
            // Return a matrix containing -1 for invalid multiplication
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows1, columns2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < columns2; j++)
            {
                double sum = 0;
                for (int k = 0; k < columns1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
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
