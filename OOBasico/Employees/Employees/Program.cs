using System;
using System.Collections.Generic;
using System.Globalization;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("How many employees will be registered?");
            int N = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Emplyoee #{i + 1}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idSearch = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                if (list[i].Id == idSearch)
                {
                    Console.Write("Enter the percentage: ");
                    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list[i].increaseSalary(percentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
