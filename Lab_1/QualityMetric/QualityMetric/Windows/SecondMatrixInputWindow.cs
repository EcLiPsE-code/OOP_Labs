using QualityMetric.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualityMetric
{
    public partial class SecondMatrixInputWindow : Form
    {
        private int[,] secondArray;
        private int countRownMatrix;
        private int countColumnMatrix;

        public SecondMatrixInputWindow()
        {
            InitializeComponent();
            this.Load += SecondMatrixInputWindow_Load;
        }
        private void SaveData_2(object sender, EventArgs e)
        {
            string[] lines = textBox10.Text.Split('\n');
            countRownMatrix = lines.Length;
            countColumnMatrix = lines[0].Split(' ').Length;
            secondArray = new int[countRownMatrix, countColumnMatrix];

            for (int i = 0; i < countRownMatrix; i++)
            {
                string[] line = lines[i].Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    secondArray[i, j] = Convert.ToInt32(line[j]);
                }
            }
            if (secondArray != null)
            {
                MyMatrix.predict = secondArray;
                MyMatrix.ColumnPredict = countColumnMatrix;
                MyMatrix.RownPredict = countRownMatrix;
                MessageBox.Show("Вторая матрица успешно прочитана");
                Close();
            }
            else
            {
                MessageBox.Show("Matrix is empty");
            }
        }

        private void SecondMatrixInputWindow_Load(object sender, EventArgs e)
        {
            MyMatrix.predict = secondArray;
            MyMatrix.ColumnPredict = countColumnMatrix;
            MyMatrix.RownPredict = countRownMatrix;
        }
    }
}
