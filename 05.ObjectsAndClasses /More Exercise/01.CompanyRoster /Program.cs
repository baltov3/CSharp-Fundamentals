using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CompanyRoster
{
    class Employee
    {
        public Employee(string name, decimal sal, string dep)
        {
            this.Name = name;
            this.Salary = sal;
            this.Department = dep;
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    class Department
    {
        public Department(string name, decimal salary)
        {
            this.DepartmentName = name;
            this.AverageSalary = salary;
            this.PeopleInDepartment = 1;
        }

        public string DepartmentName { get; set; }
        public decimal AverageSalary { get; set; }
        public int PeopleInDepartment { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string employeeName = employeeInfo[0];
                decimal employeeSalary = decimal.Parse(employeeInfo[1]);
                string employeeDepartment = employeeInfo[2];

                Employee newEmployee = new Employee(employeeName, employeeSalary, employeeDepartment);
                employees.Add(newEmployee);

                if (departments.Exists(x => x.DepartmentName == employeeDepartment))
                {
                  
                    int indexOfDepartment = departments.FindIndex(x => x.DepartmentName == employeeDepartment);
                    departments[indexOfDepartment].AverageSalary += employeeSalary;
                    departments[indexOfDepartment].PeopleInDepartment++;
                }
                else
                {
                  
                    Department newDepartment = new Department(employeeDepartment, employeeSalary);
                    departments.Add(newDepartment);
                }
            }

            for (int i = 0; i < departments.Count; i++)
            {
               
                departments[i].AverageSalary /= departments[i].PeopleInDepartment;
            }

           
            List<Department> sortedDepartments = departments.OrderBy(x => x.AverageSalary).ToList();
            Department highestPaid = sortedDepartments[sortedDepartments.Count - 1];
          
            List<Employee> highestPaidDepartmentEmployees = employees
                .Where(x => x.Department == highestPaid.DepartmentName)
                .OrderByDescending(x => x.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {highestPaid.DepartmentName}");

            foreach(Employee employee in highestPaidDepartmentEmployees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
            }
        }
    }
}
