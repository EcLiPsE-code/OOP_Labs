using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApplocation;

namespace Salary
{
    public partial class AddedEmployee : Form
    {
        public AddedEmployee()
        {
            InitializeComponent();
        }

        //кнопка 'Добавить'
        private void Added_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeSalary employee = new EmployeeSalary();
                if (lastNameText.Text != "" && nameText.Text != "" && secondNameText.Text != ""
                    && employeeWageCategoryText.Text != "" && scopeOfWorkText.Text != "" && unitCostText.Text != "")
                {
                    employee.lastName = lastNameText.Text;
                    employee.name = nameText.Text;
                    employee.secondName = secondNameText.Text;
                    employee.EmployeeWageCategory = double.Parse(employeeWageCategoryText.Text);
                    employee.ScopeOfWork = double.Parse(scopeOfWorkText.Text);
                    employee.UnitCost = double.Parse(unitCostText.Text);
                }
                else
                {
                    MessageBox.Show("Вы заполнили не все поля", "Error");
                }
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Строка имела неверный формат");
                //Console.WriteLine($"Строка имела неверный формат: {0}", ex.Message);
            }catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Некорректные данные");
                //Console.WriteLine($"Некорректные данные: {0}", ex.Message);
            }
        }
    }
}
