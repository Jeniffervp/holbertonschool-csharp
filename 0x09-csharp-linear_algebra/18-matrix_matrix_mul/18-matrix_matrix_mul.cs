using System;

class MatrixMath
{
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] wrong = new double[,] {{-1}};
        double oper = 0;
        double[,] mul;

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return (wrong);
        else
            mul = new double[matrix1.GetLength(1), matrix1.GetLength(0)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    oper = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                        oper = oper + matrix1[i, k] * matrix2[k, j];
                    mul[i, j] = oper;
                }
        return (mul);
    }
}
