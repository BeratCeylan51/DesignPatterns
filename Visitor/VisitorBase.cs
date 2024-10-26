
namespace Visitor
{
    public abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }

    public class OrganizationalStructure
    {
        public EmployeeBase Employee;

        public OrganizationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }

    public class Manager : EmployeeBase
    {
        public List<EmployeeBase> Subordinates { get; set; }

        public Manager()
        {
            Subordinates = [];
        }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            foreach (var subordinate in Subordinates)
            {
                subordinate.Accept(visitor);
            }
        }
    }

    public abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string? Name { get; set; }

        public decimal Salary { get; set; }
    }

    public class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }

    public class PayrolVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine($"{worker.Name} paid {worker.Salary}");
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine($"{manager.Name} paid {manager.Salary}");
        }
    }

    public class PayriseVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine($"{worker.Name} salary increased to {worker.Salary * (decimal)1.1}");
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine($"{manager.Name} salary increased to {manager.Salary * (decimal)1.2}");
        }
    }
}
