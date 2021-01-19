using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    public class PersonnelRegister
    {
        List<Employee> register;

        public PersonnelRegister()
        {
            register = new List<Employee>();
        }

        public void AddEmployee(string name, string salary)
        {
            if (name.Split().Length < 2)
            {
                Console.WriteLine("Please input at least both last name and first name.\n");
                return;
            }

            try
            {
                int.Parse(salary);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please input a proper number value for salary.\n");
                return;
            }

            register.Add(new Employee(name, int.Parse(salary)));

            Console.WriteLine($"{name} was successfully added!\n");
        }

        public void PrintRegister()
        {
            foreach (Employee employee in register)
            {
                employee.PrintEmployee();
            }
            Console.WriteLine();
        }

        public string PrintEmployee(int n)
        {
            if (n<register.Count)
            {
                return register[n].PrintEmployee();
            }
            else
            {
                Console.WriteLine("Non-valid id\n");
                return "null";
            }
             
        }
    }
}
