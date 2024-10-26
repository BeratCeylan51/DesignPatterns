namespace Adapter
{
    public class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    }

    public class ProductManager
    {
        private readonly ILogger? _logger;

        public ProductManager(ILogger? logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger?.Log("Logged");
            Console.WriteLine("Saved");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public class EdLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged with EdLogger {message}");
        }
    }


    #region Bu paketi nuget üzerindne indirildiğini düşünelim ve bu kodda değişiklik yapamıyoruz.
    public class Log4Net
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Logged with Log4Net {message}");
        }
    }
    #endregion
}