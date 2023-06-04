using System.Globalization;

namespace code.Entities
{
    public class OutsourcedEmployee : Employee
    {
        double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }

        public override string ToString()
        {
            return $"{Name} - {Payment().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}