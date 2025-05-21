using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRegister
{
    internal class Employee
    {
        private string name;
        private int salary;

        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }
        public int getSalary()
        { 
            return salary; 
        }
        public void setName(string name) 
        { 
            this.name = name; 
        }
        public void setSalary(int salary) 
        { 
            this.salary = salary; 
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append(' ');
            sb.Append(salary);
            return sb.ToString();
        }


    }
}
