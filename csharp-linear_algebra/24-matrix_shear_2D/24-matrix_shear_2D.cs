using System;

/// <summary>
/// Class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that shears a square 2D matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="direction"></param>
    /// <param name="factor"></param>
    /// <returns></returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != columns)
        {
            // Return a matrix containing -1 for invalid shear
            return new double[,] { { -1 } };
        }

        double[,] result = new double[rows, columns];

        if (direction == 'x')
        {
            // Shear in the X direction
            for (int i = 0; i < rows; i++)
            {
                result[i, 0] = matrix[i, 0] + factor * matrix[i, 1];
                result[i, 1] = matrix[i, 1];
            }
        }
        else if (direction == 'y')
        {
            // Shear in the Y direction
            for (int j = 0; j < columns; j++)
            {
                result[0, j] = matrix[0, j];
                result[1, j] = matrix[1, j] + factor * matrix[0, j];
            }
        }
        else
        {
            // Return a matrix containing -1 for invalid shear direction
            return new double[,] { { -1 } };
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
