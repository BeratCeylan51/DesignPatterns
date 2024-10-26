using Observer;

ProductManager productManager = new();
CustomerObserver customerObserver = new();
EmployeeObserver employeeObserver = new();

productManager.Attach(customerObserver);
productManager.Attach(employeeObserver);
productManager.Detach(customerObserver);

productManager.UpdatePrice();

Console.ReadLine();