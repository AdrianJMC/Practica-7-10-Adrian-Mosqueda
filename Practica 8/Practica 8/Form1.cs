using MagicSquareApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_8
{
    public partial class btnCheckMagicSquare : Form
    {
        public btnCheckMagicSquare()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            panelMatriz.Controls.Clear();
            int size = (int)numSize.Value; // Tamaño n del cuadrado
            int textBoxSize = 40; // Tamaño de cada TextBox (40x40 píxeles)

            // Generar dinámicamente los TextBox en el panel
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    TextBox textBox = new TextBox
                    {
                        Width = textBoxSize,
                        Height = textBoxSize,
                        Location = new System.Drawing.Point(j * textBoxSize, i * textBoxSize),
                        TextAlign = HorizontalAlignment.Center,
                        Name = $"txtBox{i}{j}"
                    };
                    panelMatriz.Controls.Add(textBox);
                }
            }
        }

        private void panelMatriz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckMagicSquare_Click(object sender, EventArgs e)
        {
            int size = (int)numSize.Value;
            int[,] matrix = new int[size, size];

            try
            {
                // Leer los valores de los TextBox para llenar la matriz
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        TextBox txtBox = (TextBox)panelMatriz.Controls[$"txtBox{i}{j}"];
                        matrix[i, j] = int.Parse(txtBox.Text);
                    }
                }

                MagicSquare magicSquare = new MagicSquare(size, matrix);
                if (magicSquare.IsMagicSquare(out int magicConstant))
                {
                    MessageBox.Show($"Es un cuadrado mágico con constante mágica: {magicConstant}");
                }
                else
                {
                    MessageBox.Show("No es un cuadrado mágico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los valores: " + ex.Message);
            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
