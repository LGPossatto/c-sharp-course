namespace code.Entities
{
    public interface IOnlinePaymentService
    {
        static float MonthTax;
        static float PaymentTax;

        public double MonthlyTotal(double value, int monthNumber);
    }
}