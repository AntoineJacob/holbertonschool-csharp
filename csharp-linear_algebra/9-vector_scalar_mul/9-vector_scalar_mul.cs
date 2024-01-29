using System;

/// <summary>
/// Class VectorMath
/// </summary>
class VectorMath
{
    
    /// <summary>
    /// Method that multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    /// <param name="vector">vector pos</param>
    /// <param name="scalar">scalar</param>
    /// <returns></returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int size = vector.Length;

        // Check if vector is 2D or 3D
        if (size != 2 && size != 3)
        {
            // Return a vector containing -1 for invalid vectors
            return new double[] { -1 };
        }

        double[] result = new double[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}
