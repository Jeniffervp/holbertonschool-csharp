using System;

class VectorMath {
    
    public static double Magnitude(double[] vector) 
    {
        if (vector.Length < 2 || vector.Length > 3)
            return (-1);

        double res = 0;

        for (int i = 0; i < vector.Length; i++) 
        {
            res = res + (vector[i] * vector[i]);
        }
        return (Math.Round(Math.Sqrt(res), 2));
    }
}
