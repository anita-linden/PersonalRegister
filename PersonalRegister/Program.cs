using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonnelRegister register = new PersonnelRegister();
            Console.WriteLine("Welcome to your employee register!");
            while (true)
            {
                Console.WriteLine("1 to add Employee.\n2 to print all employees.\nAny other input to exit!\n");

                int input;
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (input == 1)
                {
                    Console.WriteLine("Please input a name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Please input the salary:");
                    string salary = Console.ReadLine();
                    register.AddEmployee(name,salary);

                }
                else if (input == 2)
                {
                    Console.WriteLine("\nHere are all the employees: ");
                    register.PrintRegister();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }
    }
}
