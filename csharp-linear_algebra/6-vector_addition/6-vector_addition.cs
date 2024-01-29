using System;

/// <summary>
/// Class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    ///  Method that adds two vectors and returns the resulting vector.
    /// </summary>
    /// <param name="vector1">pos of vector1</param>
    /// <param name="vector2">pos of vector2</param>
    /// <returns></returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int size = vector1.Length;

        // Check if vectors are 2D or 3D and have the same size
        if ((size != 2 && size != 3) || size != vector2.Length)
        {
            // Return a vector containing -1 for invalid vectors
            return new double[] { -1 };
        }

        double[] result = new double[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}