using System;


/// <summary>
/// Class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    ///  Method that calculates and returns the length of a given vector.
    /// </summary>
    /// <param name="vector">It contain the pos</param>
    /// <returns></returns>
    public static double Magnitude(double[] vector)
    {
    int dimensions = vector.Length;

        if (dimensions != 2 && dimensions != 3)
        {
            return -1; // Invalid vector dimension
        }

        double sumOfSquares = 0;

        foreach (double component in vector)
        {
            sumOfSquares += component * component;
        }

        double length = Math.Sqrt(sumOfSquares);

        // Round to the nearest hundredth
        length = Math.Round(length, 2);

        return length;
    }
}