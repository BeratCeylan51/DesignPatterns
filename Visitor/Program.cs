using Visitor;

Manager engin = new()
{
    Name = "Engin",
    Salary = 10000
};

Manager kerem = new()
{
    Name = "Kerem",
    Salary = 9000
};

Worker ali = new()
{
    Name = "Ali",
    Salary = 8000
};

Worker veli = new()
{
    Name = "Veli",
    Salary = 8000
};

engin.Subordinates.Add(kerem);
kerem.Subordinates.Add(ali);
kerem.Subordinates.Add(veli);

OrganizationalStructure organizationalStructure = new(engin);

PayrolVisitor payrolVisitor = new();
PayriseVisitor payriseVisitor = new();

organizationalStructure.Accept(payrolVisitor);
organizationalStructure.Accept(payriseVisitor);

Console.ReadLine();