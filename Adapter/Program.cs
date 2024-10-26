using Adapter;

ProductManager productManager = new(new EdLogger());
productManager.Save();

Console.ReadLine();