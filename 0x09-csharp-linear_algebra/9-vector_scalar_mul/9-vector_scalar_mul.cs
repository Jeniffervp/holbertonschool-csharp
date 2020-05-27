using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] wrong = new double[1] {-1};
        if ((vector.Length < 2 || vector.Length > 3))
            return (wrong);

        double[] mul = new double[vector.Length];

        for (int i = 0; i < vector.Length; i++)
        {
            mul[i] = vector[i] * scalar;
        }
        return (mul);
    }
}
