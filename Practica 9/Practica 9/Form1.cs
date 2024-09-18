using MatrixApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Valor1_Matriz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor2_Matriz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor3_Matriz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor4_Matriz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor1_Matriz2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor2_Matriz2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor3_Matriz2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Valor4_Matriz2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resolver_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer las matrices de los TextBox
                int[,] matrixA = new int[2, 2]
                {
            { int.Parse(Valor1_Matriz1.Text), int.Parse(Valor2_Matriz1.Text) },
            { int.Parse(Valor3_Matriz1.Text), int.Parse(Valor4_Matriz1.Text) }
                };

                int[,] matrixB = new int[2, 2]
                {
            { int.Parse(Valor1_Matriz2.Text), int.Parse(Valor2_Matriz2.Text) },
            { int.Parse(Valor3_Matriz2.Text), int.Parse(Valor4_Matriz2.Text) }
                };

                // Crear instancia de MatrixOperations y realizar cálculos
                MatrixOperations operations = new MatrixOperations(matrixA, matrixB);

                // Suma de matrices
                int[,] sumResult = operations.AddMatrices();
                txtSum00.Text = sumResult[0, 0].ToString();
                txtSum01.Text = sumResult[0, 1].ToString();
                txtSum10.Text = sumResult[1, 0].ToString();
                txtSum11.Text = sumResult[1, 1].ToString();

                // Resta de matrices
                int[,] subResult = operations.SubtractMatrices();
                txtSub00.Text = subResult[0, 0].ToString();
                txtSub01.Text = subResult[0, 1].ToString();
                txtSub10.Text = subResult[1, 0].ToString();
                txtSub11.Text = subResult[1, 1].ToString();

                // Multiplicación de matrices
                int[,] mulResult = operations.MultiplyMatrices();
                txtMul00.Text = mulResult[0, 0].ToString();
                txtMul01.Text = mulResult[0, 1].ToString();
                txtMul10.Text = mulResult[1, 0].ToString();
                txtMul11.Text = mulResult[1, 1].ToString();

                // División de matrices
                double[,] divResult = operations.DivideMatrices();
                txtDiv00.Text = divResult[0, 0].ToString("0.##");
                txtDiv01.Text = divResult[0, 1].ToString("0.##");
                txtDiv10.Text = divResult[1, 0].ToString("0.##");
                txtDiv11.Text = divResult[1, 1].ToString("0.##");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingresa números válidos en las matrices.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSum00_Click(object sender, EventArgs e)
        {

        }

        private void txtSum01_Click(object sender, EventArgs e)
        {

        }

        private void txtSum10_Click(object sender, EventArgs e)
        {

        }

        private void txtSum11_Click(object sender, EventArgs e)
        {

        }

        private void txtSub00_Click(object sender, EventArgs e)
        {

        }

        private void txtSub01_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtSub10_Click(object sender, EventArgs e)
        {

        }

        private void txtSub11_Click(object sender, EventArgs e)
        {

        }

        private void txtMul00_Click(object sender, EventArgs e)
        {

        }

        private void txtMul01_Click(object sender, EventArgs e)
        {

        }

        private void txtMul10_Click(object sender, EventArgs e)
        {

        }

        private void txtMul11_Click(object sender, EventArgs e)
        {

        }

        private void txtDiv00_Click(object sender, EventArgs e)
        {

        }

        private void txtDiv01_Click(object sender, EventArgs e)
        {

        }

        private void txtDiv10_Click(object sender, EventArgs e)
        {

        }

        private void txtDiv11_Click(object sender, EventArgs e)
        {

        }
    }
}
