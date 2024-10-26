namespace Facade
{
    public class CrossCutongConcernsFacade
    {
        public ILogging? Logging;
        public IAuthorization? Authorization;
        public ICaching? Caching;

        public CrossCutongConcernsFacade()
        {
            Logging = new Logging();
            Authorization = new Authorization();
            Caching = new Caching();
        }
    }

    public class CustomerManager
    {
        private readonly CrossCutongConcernsFacade? _concernsFacade;

        public CustomerManager()
        {
            _concernsFacade = new();
        }

        public void Save()
        {
            _concernsFacade?.Logging?.Log();
            _concernsFacade?.Authorization?.CheckAccess();
            _concernsFacade?.Caching?.Cache();
            Console.WriteLine("Customer Saved");
        }
    }

    public interface ILogging
    {
        void Log();
    }

    public class Logging : ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }

    public interface IAuthorization
    {
        void CheckAccess();
    }

    public class Authorization : IAuthorization
    {
        public void CheckAccess()
        {
            Console.WriteLine("Access Checked");
        }
    }

    public interface ICaching
    {
        void Cache();
    }

    public class Caching : ICaching
    {
        public void Cache()
        {
            Console.WriteLine("Cached");
        }
    }
}
