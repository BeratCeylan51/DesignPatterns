using Builder;

ProductDirector productDirector = new();
var builder = new OldCustomerProductBuilder();
productDirector.GenerateProduct(builder);
var product = builder.GetProduct();

Console.WriteLine(product.Id);
Console.WriteLine(product.CategoryName);
Console.WriteLine(product.ProductName);
Console.WriteLine(product.UnitPrice);
Console.WriteLine(product.DiscountedPrice);
Console.WriteLine(product.DiscountApplied);