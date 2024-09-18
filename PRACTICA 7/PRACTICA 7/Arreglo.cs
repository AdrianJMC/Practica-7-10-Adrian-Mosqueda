using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarCerosWinForms
{
    public class Arreglo
    {
        private int[,] matriz;

        public Arreglo(int[,] matriz)
        {
            this.matriz = matriz;
        }

        public int ContarCerosEnRenglon(int renglon)
        {
            int contador = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                if (matriz[renglon, i] == 0)
                {
                    contador++;
                }
            }
            return contador;
        }

        public int Renglones => matriz.GetLength(0);

        public string ObtenerResultados()
        {
            string resultado = "";
            for (int i = 0; i < Renglones; i++)
            {
                int ceros = ContarCerosEnRenglon(i);
                resultado += $"Renglón {i + 1}: {ceros} ceros.\n";
            }
            return resultado;
        }
    }
}