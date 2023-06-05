using System.Globalization;

using code.Entities;
using code.Entities.Enums;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentService paymentService = new PaymentService(new SomePaymentService());

            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, contractValue);

            Console.WriteLine();
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= installmentsNumber; i++)
            {
                DateTime newDate = contract.Date.AddMonths(i);
                double newAmount = paymentService.OnlinePaymentService.MonthlyTotal((contract.TotalValue / installmentsNumber), i);
                Installment newInstallment = new Installment(newDate, newAmount);

                contract.AddInstallment(newInstallment);
            }

            foreach (Installment insta in contract.Installments)
            {
                Console.WriteLine(insta);
            }
            {

            }
        }
    }
}