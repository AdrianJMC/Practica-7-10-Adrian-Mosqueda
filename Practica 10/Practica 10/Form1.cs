using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_10
{
    public partial class ada : Form
    {
        public ada()
        {
            InitializeComponent();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(txtSize.Text, out size) && size > 0)
            {
                MatrixGenerator generator = new MatrixGenerator();
                int[,] matrix = generator.GenerateMatrix(size);

                dataGridViewMatrix.Rows.Clear();
                dataGridViewMatrix.Columns.Clear();

                // Configurar DataGridView
                for (int i = 0; i < size; i++)
                {
                    dataGridViewMatrix.Columns.Add("Col" + i, "Col" + i);
                }

                for (int i = 0; i < size; i++)
                {
                    object[] row = new object[size];
                    for (int j = 0; j < size; j++)
                    {
                        row[j] = matrix[i, j];
                    }
                    dataGridViewMatrix.Rows.Add(row);
                }

                lblMessage.Text = "Matriz generada correctamente.";
            }
            else
            {
                lblMessage.Text = "Por favor, ingrese un número válido.";
            }
        }

        private void dataGridViewMatrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ada_Load(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
