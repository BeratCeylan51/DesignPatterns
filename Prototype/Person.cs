namespace Prototype
{
    public abstract class Person
    {
        public abstract Person Clone();

        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }

    public class Employee : Person
    {
        public string? Company { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }

    public class Customer : Person
    {
        public string? City { get; set; }

        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
