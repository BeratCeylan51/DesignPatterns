namespace Observer
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("CustomerObserver: Reacted to the event");
        }
    }

    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("EmployeeObserver: Reacted to the event");
        }
    }

    public class ProductManager
    {
        List<Observer> _observers = [];

        public void UpdatePrice()
        {
            Console.WriteLine("ProductManager: Price updated");
            Notify();
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
