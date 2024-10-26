namespace AbstractFactory
{
    public class ProductManager
    {
        private readonly CrossCuttingConcernsFactory _crossCuttingConcernsFactory;

        private Logging _logging;
        private Caching _caching;

        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreateLogging();
            _caching = _crossCuttingConcernsFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("Data");
            Console.WriteLine("Getting all products");
        }
    }
}
