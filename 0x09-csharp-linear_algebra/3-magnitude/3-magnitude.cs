using System;

class Program {
    public static double Magnitude(double[] vector) {
        if (vector < 2 || vector > 3)
            return (-1);

        double res = 0;

        for (int i = 0; i < Lenght(vector); i++) {
            res = res + (vector[i] * vector[i]);
        }
        return (Math.Round(Math.Sqrt(res), 2));
    }
}
