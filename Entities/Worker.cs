using code.Entities.Enums;

namespace code.Entities
{
    public class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public List<HourContract> Contracts { get; private set; }
        public Department Department { get; private set; }

        public Worker(string name, WorkerLevel level, double baseSalary, string department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Contracts = new List<HourContract>();
            Department = new Department(department);
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;

            Contracts.ForEach(contract =>
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    income += contract.TotalValue();
                }
            });

            return income;
        }
    }
}