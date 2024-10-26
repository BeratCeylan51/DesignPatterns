using Prototype;

Customer customer = new Customer
{
    Id = 1,
    FirstName = "John",
    LastName = "Doe",
    City = "New York"
};

Customer customerClone = (Customer)customer.Clone();
customerClone.Id = 2;
customerClone.FirstName = "Jane";
customerClone.LastName = "Smith";
customerClone.City = "Los Angeles";

Console.WriteLine(customer.Id);
Console.WriteLine(customer.FirstName);
Console.WriteLine(customer.LastName);
Console.WriteLine(customer.City);
Console.WriteLine("------------------------------------");
Console.WriteLine(customerClone.Id);
Console.WriteLine(customerClone.FirstName);
Console.WriteLine(customerClone.LastName);
Console.WriteLine(customerClone.City);