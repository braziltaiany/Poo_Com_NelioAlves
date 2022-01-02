using System;
using System.Collections.Generic;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee2> list = new List<Employee2>();

            list.Add(new Employee2(123, "maria", 200.0));
            list.Add(new Employee2(111, "Joao", 300.0));
            list.Add(new Employee2(112, "Joana", 500.0));
            list.Add(new Employee2(113, "Joa", 400.0));


            Console.WriteLine("list count: " + list.Count);
            Console.WriteLine("-----------------");
            
            list.Insert(0, new Employee2(113, "Bob", 100.0));
            Console.WriteLine("list count: " + list.Count);
            Console.WriteLine("-----------------");

            int i = 0;

            foreach (Employee2 obj in list)
            {
                Console.WriteLine($"[{i}]: {obj}");
                i++;
            }
            Console.WriteLine("-----------------");

            Employee2 emp = list.Find(x => x.Id == 123);
            Employee2 emp1 = list.Find(x => x.Salary == 100);
            Employee2 emp2 = list.Find(x => x.Name == "Joa");
           

            Console.WriteLine(emp);
            Console.WriteLine("-----------------");
            Console.WriteLine(emp1);
            Console.WriteLine("-----------------");
            Console.WriteLine(emp2);



            //Console.WriteLine("list[0]");
            //Console.WriteLine(list[0].Id);
            //Console.WriteLine(list[0].Salary);
            //Console.WriteLine(list[0].Name);
            //Console.WriteLine("1-----------------");
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //Console.WriteLine("2-----------------");
        }
    }
}
