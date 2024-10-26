namespace FactoryMethod
{
    // Fabrika
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new EdLogger();
        }
    }

    // Fabrika
    public class LoggerFactory2 : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            return new Log4NetLogger();
        }
    }

    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("EdLogger: " + message);
        }
    }

    public class Log4NetLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log4NetLogger: " + message);
        }
    }

    public class  CustomerManager(ILoggerFactory loggerFactory)
    {
        public void Save()
        {
            Console.WriteLine("Saved");
            ILogger logger = loggerFactory.CreateLogger();
            logger.Log("Logged");
        }
    }
}
