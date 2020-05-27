using System;

class VectorMath 
{
    public static double[] Add(double[] vector1, double[] vector2) 
    {
        double[] wrong = new double[1] {-1};
        if ((vector1.Length < 2 || vector1.Length > 3) && (vector2.Length < 2 || vector2.Length > 3) || (vector1.Length != vector2.Length))
        {
            return (wrong);
        }
        double[] sum = new double[vector1.Length];

        for (int i = 0; i < vector1.Length && i < vector2.Length; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }
        return (sum);
    }
}