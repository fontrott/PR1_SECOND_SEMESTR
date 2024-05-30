using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PR333333333
{
    public partial class Form1 : Form
    {
        private int[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RearrangeMatrix(int[,] matrix, int matrixSize)
        {
            int n = matrixSize * matrixSize;
            int[] elements = new int[n];

            int index = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    elements[index] = matrix[i, j];
                    index++;
                }
            }

            Random rand = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                int j = rand.Next(0, i + 1);
                int temp = elements[i];
                elements[i] = elements[j];
                elements[j] = temp;
            }

            index = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = elements[index];
                    index++;
                }
            }
        }
        private void FillMatrixButton_Click(object sender, EventArgs e)
        {
            groupBoxMatrix.Controls.Clear();
            int count = 0;
            int matrixSize = Convert.ToInt32(MatrixSizeTextBox.Text);
            int[,] matrix = new int[matrixSize, matrixSize];
            Random random = new Random();
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    count++;
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();
                    textBox.Name = $"textBox{count}";
                    textBox.Location = new System.Drawing.Point(123 + j * 30, 40 + i * 20);
                    textBox.Size = new System.Drawing.Size(30, 30);
                    textBox.TabIndex = count;
                    textBox.ReadOnly = true;
                    int number = random.Next(-9, 9);
                    matrix[i, j] = number;
                    textBox.Text = number.ToString();
                    groupBoxMatrix.Controls.Add(textBox);
                }
            }
        }
        private void UpdateMatrix(int[,] matrix, int matrixSize)
        {
            RearrangeMatrix(matrix, matrixSize);
            int textBoxCount = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    foreach (Control control in groupBoxMatrix.Controls)
                    {
                        if (control is TextBox && control.Name == $"textBox{textBoxCount + 1}")
                        {
                            ((TextBox)control).Text = matrix[i, j].ToString();
                            textBoxCount++;
                        }
                    }
                }
            }
        }
        private void btn_Close1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_Close2_Click(object sender, EventArgs e)
        {
            btn_Close1_Click(sender, e);
        }

        private void btn_ChangeTheMatrix_Click(object sender, EventArgs e)
        {
            int matrixSize = Convert.ToInt32(MatrixSizeTextBox.Text);
            int count = 0;
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    foreach (Control control in groupBoxMatrix.Controls)
                    {
                        if (control is TextBox && control.Name == $"textBox{count + 1}")
                        {
                            if (int.TryParse(((TextBox)control).Text, out int value))
                            {
                                matrix[i, j] = value;
                            }
                            count++;
                        }
                    }
                }
            }
            UpdateMatrix(matrix, matrixSize);
        }
    }
}
