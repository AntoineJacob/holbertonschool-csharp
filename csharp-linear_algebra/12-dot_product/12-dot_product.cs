using System;

/// <summary>
/// Class VectorMath
/// </summary>
class VectorMath
{
    
    /// <summary>
    /// Method that calculates dot product of either two 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1">vector1 pos</param>
    /// <param name="vector2">vector2 pos</param>
    /// <returns>Return -1 if invalid vector</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int size = vector1.Length;

        // Check if vectors are either both 2D or both 3D and have the same size
        if ((size != 2 && size != 3) || size != vector2.Length)
        {
            // Return -1 for invalid vectors
            return -1;
        }

        double result = 0;

        for (int i = 0; i < size; i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }
}
