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
        protected List<int> SecondArray = new List<int>();
        public SecondMatrixInputWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SecondArray = textBox1.Text.Split(' ').Select(x => int.Parse(x)).ToList();

            MessageBox.Show("Вторая матрица успешно прочитана");
        }
    }
}
