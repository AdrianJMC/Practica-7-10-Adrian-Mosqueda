using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixApp
{
    public class MatrixOperations
    {
        private int[,] matrixA;
        private int[,] matrixB;

        public MatrixOperations(int[,] matrixA, int[,] matrixB)
        {
            this.matrixA = matrixA;
            this.matrixB = matrixB;
        }

        public int[,] AddMatrices()
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            return result;
        }

        public int[,] SubtractMatrices()
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            return result;
        }

        public int[,] MultiplyMatrices()
        {
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrixA[i, j] * matrixB[i, j];
                }
            }
            return result;
        }

        public double[,] DivideMatrices()
        {
            double[,] result = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (matrixB[i, j] != 0)
                    {
                        result[i, j] = (double)matrixA[i, j] / matrixB[i, j];
                    }
                    else
                    {
                        result[i, j] = double.NaN; // O manejar la división por cero de alguna manera
                    }
                }
            }
            return result;
        }
    }
}
