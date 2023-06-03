using System.Globalization;

using code.Entities;
using code.Entities.Enums;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Worker level (Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(name, level, baseSalary, department);

            Console.Write("How many contracts for this worker: ");
            int contractsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < contractsNumber; i++)
            {
                Console.Write($"Enter {i + 1}# contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double contractHourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (HOURS): ");
                int contractHours = int.Parse(Console.ReadLine());

                worker.AddContract(new HourContract(contractDate, contractHours, contractHourValue));
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] dateIncome = Console.ReadLine().Split("/");

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income: {worker.Income(int.Parse(dateIncome[1]), int.Parse(dateIncome[0]))}");
        }
    }
}