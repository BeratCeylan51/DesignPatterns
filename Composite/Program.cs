using Composite;

Employee people1 = new() { Name = "John" };
Employee people2 = new() { Name = "Jane" };
Employee people3 = new() { Name = "Jack" };
Employee people4 = new() { Name = "Jill" };

Contractor ali = new() { Name = "Ali" };
people4.AddSubordinate(ali);

people1.AddSubordinate(people2);
people1.AddSubordinate(people4);

people2.AddSubordinate(people3);

Console.WriteLine(people1.Name);
foreach (Employee person in people1)
{
    Console.WriteLine($"-{person.Name}");
    foreach (var subordinate in person)
    {
        Console.WriteLine($"--{subordinate.Name}");
    }
}