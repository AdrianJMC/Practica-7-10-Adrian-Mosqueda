using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquareApp
{
    public class MagicSquare
    {
        private int[,] matrix;
        private int size;

        public MagicSquare(int size, int[,] matrix)
        {
            this.size = size;
            this.matrix = matrix;
        }

        public bool IsMagicSquare(out int magicConstant)
        {
            int sumDiagonal1 = 0, sumDiagonal2 = 0;
            magicConstant = 0;

            // Sumar la primera fila para obtener la constante mágica
            for (int i = 0; i < size; i++)
            {
                magicConstant += matrix[0, i];
            }

            // Verificar filas y columnas
            for (int i = 0; i < size; i++)
            {
                int sumRow = 0, sumCol = 0;
                for (int j = 0; j < size; j++)
                {
                    sumRow += matrix[i, j];
                    sumCol += matrix[j, i];
                }

                if (sumRow != magicConstant || sumCol != magicConstant)
                    return false;

                sumDiagonal1 += matrix[i, i];
                sumDiagonal2 += matrix[i, size - i - 1];
            }

            // Verificar diagonales
            if (sumDiagonal1 != magicConstant || sumDiagonal2 != magicConstant)
                return false;

            return true;
        }
    }
}