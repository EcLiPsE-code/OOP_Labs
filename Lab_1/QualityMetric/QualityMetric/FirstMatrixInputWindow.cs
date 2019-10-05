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
    public partial class FirstMatrixInputWindow : Form
    {
        protected List<int> FirstArray = new List<int>();

        public FirstMatrixInputWindow()
        {
            InitializeComponent();
        }

        private void SaveData(object sender, EventArgs e)
        {
            FirstArray = textBox1.Text.Split(' ').Select(x => int.Parse(x)).ToList();
            
            MessageBox.Show("Первая матрица успешно прочитана");
        }
    }
}
