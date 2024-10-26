using Proxy;

// CreditManager sınıfını kullanarak gerçekleştirdiğimiz hesaplama işlemi ayrı ayrı yapılırken, CreditManagerProxy sınıfını kullanarak gerçekleştirdiğimiz hesaplama işlemi bir kere yapılır ve sonraki isteklerde aynı sonuç kullanılır.

CreditBase creditManager = new CreditManager();
Console.WriteLine(creditManager.Calculate());
Console.WriteLine(creditManager.Calculate());

Console.WriteLine("------------------------------------");

CreditBase creditManagerProxy = new CreditManagerProxy();
Console.WriteLine(creditManagerProxy.Calculate());
Console.WriteLine(creditManagerProxy.Calculate());