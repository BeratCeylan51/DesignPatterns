namespace Command
{
    public class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [ Name: " + _name + ", Quantity: " + _quantity + " ] bought");
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ Name: " + _name + ", Quantity: " + _quantity + " ] sold");
        }
    }

    public interface IOrder
    {
        void Execute();
    }

    public class BuyStock : IOrder
    {
        private StockManager _stockManager;

        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Buy();
        }
    }

    public class SellStock : IOrder
    {
        private StockManager _stockManager;

        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public void Execute()
        {
            _stockManager.Sell();
        }
    }

    public class StockController
    {
        List<IOrder> _orders = [];

        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }
            _orders.Clear();
        }
    }
}
