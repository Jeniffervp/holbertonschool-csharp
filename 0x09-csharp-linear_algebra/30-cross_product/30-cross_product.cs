using System;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] wrong = new double[]{-1};
        double[] res;
        if (vector1.Length != 3 || vector2.Length != 3)
            return wrong;
        res = new double[vector1.Length];
        res[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        res[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        res[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return res;
    }
}
