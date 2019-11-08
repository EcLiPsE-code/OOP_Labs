using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApplocation
{
    public class Employee
    {
        public string name { get; set; } //имя сотрудника
        public string lastName { get; set; } //фамилия сотрудника
        public string secondName { get; set; } //отчество сотрудника

        public double employeeWageCategory { get; private set; } //тарифная категория работника.
        public double scopeOfWork { get; private set; } //объем выполненной работы (в процентах).
        public double unitCost { get; private set; } //стоимость единицы продукции.

        public Employee(string name, string lastName, string secondName, double employeeWageCategory, double scopeOfWork
                              , double unitCost)
        {
            this.name = name;
            this.lastName = lastName;
            this.secondName = secondName;
            this.employeeWageCategory = employeeWageCategory;
            this.scopeOfWork = scopeOfWork;
            this.unitCost = unitCost;
        }
        public Employee(){}
        public double EmployeeWageCategory //сеттер для тарифной категории работника
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect format employeeWageCategory");
                }
                employeeWageCategory = value;
            }
        }

        public double ScopeOfWork //сеттер для объема выполненной работы
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Incorrect format scopeOfWork");
                }
                scopeOfWork = value;
            }
        }

        public double UnitCost //сеттер для стоимости единицы продукции
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Incorrect format unitCost");
                }
                unitCost = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + name + "\nLast Name: " + lastName + "\nSecond Name: " + secondName + "\nEmployee Wage Category: " +
                +employeeWageCategory + "\nScope of Work: " + scopeOfWork + "\nUnit Cost: " + unitCost + ".";
        }

        public override bool Equals(object obj)
        {
            if (this == obj){
                return true;
            }
            if (obj == null || this.getClass != obj.getClass){
                return false;
            }
            Employee employee = (Employee) obj;
            if(this.name == employee.name || this.lastName == employee.lastName || this.secondName == employee.secondName || this.employeeWageCategory == employee.employeeWageCategory ||
                this.scopeOfWork == employee.scopeOfWork || this.unitCost == employee.unitCost){
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            int result = 4;
            result = 12 * result + name.Length;
            result = 12 * result + lastName.Length;
            result = 12 * result + secondName.Length;
            result = 12 * result + (int)employeeWageCategory;
            result = 12 * result + (int)scopeOfWork;
            result = 12 * result + (int)unitCost;
            return result;
        }
    }
}
