using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_7
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matriz = new int[5, 5];

                // Llenar la matriz con los valores de los TextBox
                matriz[0, 0] = int.Parse(textBox1.Text);
                matriz[0, 1] = int.Parse(textBox2.Text);
                matriz[0, 2] = int.Parse(textBox3.Text);
                matriz[0, 3] = int.Parse(textBox4.Text);
                matriz[0, 4] = int.Parse(textBox5.Text);

                matriz[1, 0] = int.Parse(textBox6.Text);
                matriz[1, 1] = int.Parse(textBox7.Text);
                matriz[1, 2] = int.Parse(textBox8.Text);
                matriz[1, 3] = int.Parse(textBox9.Text);
                matriz[1, 4] = int.Parse(textBox10.Text);

                matriz[2, 0] = int.Parse(textBox11.Text);
                matriz[2, 1] = int.Parse(textBox12.Text);
                matriz[2, 2] = int.Parse(textBox13.Text);
                matriz[2, 3] = int.Parse(textBox14.Text);
                matriz[2, 4] = int.Parse(textBox15.Text);

                matriz[3, 0] = int.Parse(textBox16.Text);
                matriz[3, 1] = int.Parse(textBox17.Text);
                matriz[3, 2] = int.Parse(textBox18.Text);
                matriz[3, 3] = int.Parse(textBox19.Text);
                matriz[3, 4] = int.Parse(textBox20.Text);

                matriz[4, 0] = int.Parse(textBox21.Text);
                matriz[4, 1] = int.Parse(textBox22.Text);
                matriz[4, 2] = int.Parse(textBox23.Text);
                matriz[4, 3] = int.Parse(textBox24.Text);
                matriz[4, 4] = int.Parse(textBox25.Text);

                // Calcular los ceros por cada renglón
                string resultado = "";
                for (int i = 0; i < 5; i++)
                {
                    int contadorCeros = 0;
                    for (int j = 0; j < 5; j++)
                    {
                        if (matriz[i, j] == 0)
                        {
                            contadorCeros++;
                        }
                    }
                    resultado += $"Renglón {i + 1}: {contadorCeros} ceros.\n";
                }

                // Mostrar el resultado en el TextBox grande
                TextBoxResultado.Text = resultado;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            TextBoxResultado.Clear();
        }

        private void TextBoxResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
