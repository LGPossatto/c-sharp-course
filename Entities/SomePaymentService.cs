namespace code.Entities
{
    public class SomePaymentService : IOnlinePaymentService
    {
        static float MonthTax = 0.01F;
        static float PaymentTax = 0.02F;

        public double MonthlyTotal(double value, int monthNumber)
        {
            double totalValue = value + (value * MonthTax * monthNumber);
            return totalValue + (totalValue * PaymentTax);
        }
    }
}