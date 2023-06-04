using System.Globalization;

using code.Entities;
using code.Entities.Enums;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int employeesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeesNumber; i++)
            {
                Console.WriteLine($"Employees {i + 1}# data: ");
                Console.Write("Outsourcer (y/n)? ");
                char isOutsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                if (isOutsourced == 'y')
                {
                    Console.Write("Addicional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Employees");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}