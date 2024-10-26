namespace AbstractFactory
{
    public abstract class CrossCuttingConcernsFactory
    {
        public abstract Logging CreateLogging();
        public abstract Caching CreateCaching();
    }

    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogging()
        {
            return new Log4NetLogger();
        }

        public override Caching CreateCaching()
        {
            return new RedisCache();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Logging CreateLogging()
        {
            return new NLogger();
        }

        public override Caching CreateCaching()
        {
            return new RedisCache();
        }
    }
}
