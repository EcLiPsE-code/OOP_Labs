using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SalaryApplocation
{
    public class WorkWithXML
    {
        public List<EmployeeSalary> employees = new List<EmployeeSalary>();
        public void printDataXML()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("employees.xml");
            XmlElement xEl = xDoc.DocumentElement;

            string name = null, lastName = null, secondName = null;
            double employeeWageCategory = 0, scopeOfWork = 0, unitCost = 0;

            foreach (XmlNode xNode in xEl)
            {
               foreach (XmlNode childNode in xNode.ChildNodes)
                {
                    if (childNode.Name == "name")
                    {
                        name = childNode.InnerText;
                    }
                    if (childNode.Name == "lastName")
                    {
                        lastName = childNode.InnerText;
                    }
                    if (childNode.Name == "secondName")
                    {
                        secondName = childNode.InnerText;
                    }
                    if (childNode.Name == "employeeWageCategory")
                    {
                        employeeWageCategory = double.Parse(childNode.InnerText);
                    }
                    if (childNode.Name == "scopeOfWork")
                    {
                        scopeOfWork = double.Parse(childNode.InnerText);
                    }
                    if (childNode.Name == "unitCost")
                    {
                        unitCost = double.Parse(childNode.InnerText);
                    }
                }
                employees.Add(new EmployeeSalary(name, lastName, secondName, employeeWageCategory, scopeOfWork, unitCost));
            }
        }

        public string readList()
        {
            string msg = "";
            foreach (EmployeeSalary employee in employees)
            {
                msg += employee.ToString() + "\n";     
            }
            return msg;
        }
    }
}
