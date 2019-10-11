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
        }
        
        private void SaveData(object sender, EventArgs e)
        {
            try
            {
                string[] lines = textBox1.Text.Split('\n');
                countRownMatrix = lines.Length;
                countColumnMatrix = lines[0].Split(' ').Length;
                array = new int[countRownMatrix, countColumnMatrix];

                for (int i = 0; i < countRownMatrix; i++)
                {
                    string[] line = lines[i].Split(' ');
                    for (int j = 0; j < line.Length; j++)
                    {
                        array[i, j] = Convert.ToInt32(line[j]);
                    }
                }
                if (countColumnMatrix != countRownMatrix)
                {
                    throw new FormatException("Uncrottect format matrix");
                }
                if (array != null)
                {
                    MyMatrix.fact_value = array;
                    MyMatrix.ColumnFactValue = countColumnMatrix;
                    MyMatrix.RownFactValue = countRownMatrix;
                    MyMatrix.ProverkaFactValue();

                    MessageBox.Show("Первая матрица успешно прочитана");
                    Close();
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
