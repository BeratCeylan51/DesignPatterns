namespace NullObject
{
    public class CustomerManager
    {
        private ILogger _logger;

        public CustomerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            Console.WriteLine("Customer saved");
            _logger.Log("Logged");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class NLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with NLogger");
        }
    }

    public class Log4NetLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged with Log4NetLogger");
        }
    }

    public class StubLogger : ILogger
    {
        private static StubLogger _instance;
        private static object _lock = new();

        private StubLogger()
        {
        }

        public static StubLogger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new StubLogger();
                    }
                    return _instance;
                }
            }
        }
        public void Log(string message)
        {
            // Do nothing
        }
    }

    public class CustomerManagerTest
    {
        public void SaveTest()
        {
            CustomerManager customerManager = new(StubLogger.Instance);
            customerManager.Save();
        }
    }
}
