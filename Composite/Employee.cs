using System.Collections;

namespace Composite
{
    public class Employee : IPerson, IEnumerable<IPerson>
    {
        List<IPerson> _subordinates = [];
        public required string Name { get; set; }

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public interface IPerson
    {
        string Name { get; set; }
    }

    public class Contractor : IPerson
    {
        public required string Name { get; set; }
    }
}
