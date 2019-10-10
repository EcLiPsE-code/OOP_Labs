using QualityMetric.Entity;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QualityMetric
{
    public partial class FirstMatrixInputWindow : Form
    {
        private int[,] array;
        private int countRownMatrix;
        private int countColumnMatrix;

        public FirstMatrixInputWindow()
        {
            InitializeComponent();
            this.Load += FirstMatrixInputWindow_Load;
        }
        
        private void SaveData(object sender, EventArgs e)
        {
            string[] lines = textBox1.Text.Split('\n');
            countRownMatrix = lines.Length;
            countColumnMatrix = lines[0].Split(' ').Length;
            array = new int[countRownMatrix,countColumnMatrix];

            for (int i = 0; i < countRownMatrix; i++)
            {
                string[] line = lines[i].Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    array[i, j] = Convert.ToInt32(line[j]);
                }
            }
            if (array != null)
            {
                MyMatrix.fact_value = array;
                MyMatrix.ColumnFactValue = countColumnMatrix;
                MyMatrix.RownFactValue = countRownMatrix;
                MessageBox.Show("Первая матрица успешно прочитана");
                Close();
            }
            else
            {
                MessageBox.Show("Матрица пустая.");
            }
        }

        private void FirstMatrixInputWindow_Load(object sender, EventArgs e)
        {
            MyMatrix.fact_value = array;
            MyMatrix.ColumnFactValue = countColumnMatrix;
            MyMatrix.RownFactValue = countRownMatrix;
        }
    }
}
