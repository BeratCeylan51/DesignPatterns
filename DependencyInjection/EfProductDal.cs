namespace DependencyInjection
{
    public class EfProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with EF");
        }
    }

    public class NhProductDal : IProductDal
    {
        public void Save()
        {
            Console.WriteLine("Saved with Nh");
        }
    }

    public interface IProductDal
    {
        void Save();
    }

    public class ProductManager
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Save()
        {
            _productDal.Save();
        }
    }
}
