
namespace Mediator
{
    public class Mediator
    {
        public Teacher? Teacher { get; set; }

        public List<Student>? Students { get; set; }

        public void UpdateImage(string url)
        {
            if (Students == null) return;
            foreach (var student in Students)
            {
                student.RecieveImage(url, student);
            }
        }

        public void SendQuestion(string question, Student student)
        {
            Teacher?.RecieveQuestion(question, student);
        }

        public void SendAnswer(string answer, Student student)
        {
            student.RecieveAnswer(answer, student);
        }
    }

    public class  CourseMember
    {
        protected Mediator Mediator;

        public CourseMember(Mediator mediator)
        {
            Mediator = mediator;
        }
    }

    public class Teacher(Mediator mediator) : CourseMember(mediator)
    {
        public string? Name { get; set; }

        public void RecieveQuestion(string question, Student student)
        {
            Console.WriteLine($"Teacher recieved a question from {student.Name}, the question is : {question}");
        }

        public void SendNewImage(string url)
        {
            Console.WriteLine($"Teacher changed slide : {url}");
            Mediator?.UpdateImage(url);
        }

        public void AnswerQuestion(string answer, Student student)
        {
            Console.WriteLine($"Teacher answered question : {answer}, {student.Name}");
            Mediator?.SendAnswer(answer, student);
        }
    }

    public class Student : CourseMember
    {
        public Student(Mediator mediator) : base(mediator)
        {
        }

        public void RecieveAnswer(string answer, Student student)
        {
            Console.WriteLine($"Student received answer : {answer} {student.Name}");
        }

        public void RecieveImage(string url, Student student)
        {
            Console.WriteLine($"{student.Name} received image : {url}");
        }

        public string? Name { get; set; }
    }
}
