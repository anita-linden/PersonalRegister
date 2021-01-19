using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    public class Employee
    {
        private string name;
        private int salary;
        public Employee(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string PrintEmployee()
        {
            Console.WriteLine($"{name} {salary:C}");
            return $"{name}: {salary:C}";
        }
    }
}
