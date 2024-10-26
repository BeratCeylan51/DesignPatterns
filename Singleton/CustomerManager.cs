namespace Singleton
{
    public class CustomerManager
    {
        private static CustomerManager? _customerManager;

        // İlk customerManager oluşturma işleminde multithread uygulamalarda aynı anda birden fazla instance oluşturulmasını engellemek için lock işlemi ekliyoruz.
        private static readonly object _lockObject = new();
        private CustomerManager()
        {

        }

        // Singleton örneğini oluşturacak bir metod yazıyoruz.
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                _customerManager ??= new CustomerManager();
            }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved");
        }
    }
}
