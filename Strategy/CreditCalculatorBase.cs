namespace Strategy
{
    public abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    public class PersonalFinanceCreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Personal finance credit calculated");
        }
    }

    public class VehicleCreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Vehicle credit calculated");
        }
    }

    public class CustomerManager
    {
        public required CreditCalculatorBase CreditCalculatorBase { get; set; }

        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            CreditCalculatorBase.Calculate();
        }
    }
}
