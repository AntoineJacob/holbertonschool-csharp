using System;

/// <summary>
/// New matrix class calculation
/// </summary>
class MatrixMath
{
    /// <summary>
    /// New add method for matrix
    /// </summary>
    /// <param name="matrix">matrix gift in argument to the method</param>
    /// <param name="direction">x or y</param>
    /// <param name="factor">number for the multiplication</param>
    /// <returns>sum of two matrixes</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] error = new double[1, 1] { { -1 } };


        if (matrix.GetLength(1) != matrix.GetLength(0) || matrix.GetLength(0) > 2 || direction != 'x' && direction != 'y')
        {
            return error;
        }

        if (direction.Equals('x'))
        {
            result[0, 0] = matrix[0, 1] * factor + matrix[0, 0];
            result[0, 1] = matrix[0, 1];
            result[1, 0] = matrix[1, 1] * factor + matrix[1, 0];
            result[1, 1] = matrix[1, 1];
        }
        else if (direction.Equals('y'))
        {
            result[0, 0] = matrix[0, 0];
            result[0, 1] = matrix[0, 0] * factor + matrix[0, 1];
            result[1, 0] = matrix[1, 0];
            result[1, 1] = matrix[1, 0] * factor + matrix[1, 1];
        }

        return result;
    }
}