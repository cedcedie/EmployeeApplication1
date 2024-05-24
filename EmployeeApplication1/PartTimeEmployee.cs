using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication1
{
    internal class PartTimeEmployee : Iemployee
    {
        private string first_Name;
        private string lastName;
        private string department;
        private string job_Title;
        private double basic_salary;
        public int hoursWorked;
        public double ratePerHour;

        public PartTimeEmployee(string Fname, string Lname, string dept, string job)
        {
            this.first_Name = Fname;
            this.lastName = Lname;
            this.department = dept;
            this.job_Title = job;

        }
        public string FirstName
        {
            get
            {
                return first_Name;
            }
            set
            {
                first_Name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public string JobTitle
        {
            get
            {
                return job_Title;
            }
            set
            {
                job_Title = value;
            }
        }

        public double BasicSalary
        {
            get
            {
                return basic_salary;
            }set
            {
                basic_salary = value;
            }
           
        }

        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }

        public double getSalary()
        {
            return this.basic_salary;
        }


    }
}
