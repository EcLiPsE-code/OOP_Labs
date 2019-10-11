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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EnterFirstMatrix(object sender, EventArgs e)
        {
            FirstMatrixInputWindow firstMatrix = new FirstMatrixInputWindow();
            firstMatrix.Show();
        }

        private void EnterSecondMatrix(object sender, EventArgs e)
        {
            SecondMatrixInputWindow secondMatrix = new SecondMatrixInputWindow();
            secondMatrix.Show();
        }


        //Вывод результата
        private void PrintResult(object sender, EventArgs e)
        {
            MyMatrix.NumberOfRatings();
            label1.Text = MyMatrix.PrintResult();
        }

    }
}
