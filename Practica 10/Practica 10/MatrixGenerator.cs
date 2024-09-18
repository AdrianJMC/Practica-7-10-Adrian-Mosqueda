using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_10
{
    public class MatrixGenerator
    {
        public int[,] GenerateMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                matrix[i, i] = 1; // Colocar 1 en la diagonal principal
                for (int j = 0; j < size; j++)
                {
                    if (i != j)
                    {
                        matrix[i, j] = 0; // Colocar 0 en las demás posiciones
                    }
                }
            }

            return matrix;
        }
    }
}
 