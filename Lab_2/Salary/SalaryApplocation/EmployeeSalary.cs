using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApplocation
{
    public class EmployeeSalary
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string secondName { get; set; }

        public double employeeWageCategory { get; private set; } //тарифная категория работника.
        public double scopeOfWork { get; private set; } //объем выполненной работы (в процентах).
        public double unitCost { get; private set; } //стоимость единицы продукции.

        public EmployeeSalary(string name, string lastName, string secondName, double employeeWageCategory, double scopeOfWork
                              , double unitCost)
        {
            this.name = name;
            this.lastName = lastName;
            this.secondName = secondName;
            this.employeeWageCategory = employeeWageCategory;
            this.scopeOfWork = scopeOfWork;
            this.unitCost = unitCost;
        }

        public EmployeeSalary()
        {

        }
        public double EmployeeWageCategory
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

        public double ScopeOfWork
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

        public double UnitCost
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
    }
}
