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
        if (vector.Length != 2)
        {
            throw new ArgumentException("Vector must be 2-dimensional.");
        }

        double x = vector[0];
        double y = vector[1];

        // Pythagorean theorem: length = sqrt(x^2 + y^2)
        double length = Math.Sqrt(x * x + y * y);

        return length;
    }
}