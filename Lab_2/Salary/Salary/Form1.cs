using SalaryApplocation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class Form1 : Form
    {
        private String fileName;
        public Form1()
        {
            InitializeComponent();
        }

        //кнопка 'Выбрать'
        private void SelectFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы XML|*.xml";
            openFileDialog.Multiselect = true;
            openFileDialog.ReadOnlyChecked = false;

            openFileDialog.ShowDialog();
            fileName = openFileDialog.SafeFileName;
            if (fileName != "")
            {
                comboBox1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл", "Error");
            }
        }

        //кнопка 'Выполнить'
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ДОБАВЛЕНИЕ")
            {
                AddedEmployee employee = new AddedEmployee();
                employee.Show();
            }
            else if (comboBox1.Text == "УДАЛЕНИЕ")
            {
                DeletedEmployee employee = new DeletedEmployee();
                employee.Show();
            }
        }
    }
}
