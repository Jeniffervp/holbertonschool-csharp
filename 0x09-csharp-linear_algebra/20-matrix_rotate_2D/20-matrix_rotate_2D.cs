﻿using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] wrong = new double[,] { { -1 } };
        double[,] matrix1 = new double[,] {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
        double oper;
        double[,] res = new double[2, 2];
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2)
            return wrong;
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
            {
                oper = 0;
                for (int k = 0; k < 2; k++)
                    oper = oper + Math.Round((matrix[i, k] * matrix1[k, j]), 2);
                res[i, j] = oper;
            }
        return res;
    }
}
