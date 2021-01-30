﻿
public static class NumberHelper
{
    /// Random seed
    private static readonly System.Random m_Random = new System.Random();

    /// <summary>
    /// Returns a random number in the range {min, max}.
    /// </summary>
    /// <param name="min">Minimum value</param>
    /// <param name="max">Maximum value</param>
    /// <returns>Returns the random number</returns>
    public static int RandomInRange(int min, int max)
    {
        // + 1 to include the max value also in the posible values
        return m_Random.Next() % (max + 1 - min) + min;
    }
}