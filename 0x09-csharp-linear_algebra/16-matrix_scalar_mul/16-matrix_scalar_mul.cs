using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] wrong = new double[,] {{-1}};
        if ((matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3) || (matrix.GetLength(0) != matrix.GetLength(1)))
            return (wrong);

        double[,] mul = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                mul[i, j] = matrix[i, j] * scalar;
        
        return (mul);
    }
}
