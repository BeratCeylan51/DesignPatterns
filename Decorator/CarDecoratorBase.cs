namespace Decorator
{
    public abstract class CarDecoratorBase : CarBase
    {
        private readonly CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    public abstract class CarBase
    {
        public abstract string Make { get; set; }

        public abstract string Model { get; set; }

        public abstract decimal HirePrice { get; set; }
    }

    public class PersonalCar : CarBase
    {
        public override required string Make { get; set; }

        public override required string Model { get; set; }

        public override required decimal HirePrice { get; set; }
    }

    public class CommercialCar : CarBase
    {
        public override required string Make { get; set; }

        public override required string Model { get; set; }

        public override required decimal HirePrice { get; set; }
    }

    public class SpecialOffer : CarDecoratorBase
    {
        private readonly CarBase _carBase;

        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }

        public int DiscountPercentage { get; set; }
        public override string Make { get => _carBase.Make; set { } }
        public override string Model { get => _carBase.Model; set { } }
        public override decimal HirePrice { get => _carBase.HirePrice - _carBase.HirePrice * DiscountPercentage / 100; set { } }
    }
}
