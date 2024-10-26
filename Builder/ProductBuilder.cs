namespace Builder
{
    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetProduct();
    }

    public class ProductViewModel
    {
        public int Id { get; set; }

        public string? CategoryName { get; set; }

        public string? ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal DiscountedPrice { get; set; }

        public bool DiscountApplied { get; set; }
    }

    class NewCustomerProductBuilder : ProductBuilder
    {
        private ProductViewModel _product = new ProductViewModel();

        public override void GetProductData()
        {
            _product.Id = 1;
            _product.CategoryName = "Electronics";
            _product.ProductName = "Laptop";
            _product.UnitPrice = 1000;
        }

        public override void ApplyDiscount()
        {
            _product.DiscountedPrice = _product.UnitPrice * (decimal)0.90;
            _product.DiscountApplied = true;
        }

        public override ProductViewModel GetProduct()
        {
            return _product;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        private ProductViewModel _product = new ProductViewModel();

        public override void GetProductData()
        {
            _product.Id = 1;
            _product.CategoryName = "Electronics";
            _product.ProductName = "Laptop";
            _product.UnitPrice = 1000;
        }

        public override void ApplyDiscount()
        {
            _product.DiscountedPrice = _product.UnitPrice;
            _product.DiscountApplied = false;
        }

        public override ProductViewModel GetProduct()
        {
            return _product;
        }
    }

    class ProductDirector
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
        }
    }
}
