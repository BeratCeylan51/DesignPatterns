using Mediator;

Mediator.Mediator mediator = new();
Teacher teacher = new(mediator);
teacher.Name = "Engin";

Student student = new(mediator);
student.Name = "Kaan";

Student student1 = new(mediator);
student1.Name = "Ahmet";

mediator.Students = [student, student1];

teacher.SendNewImage("slide1.jpg");

teacher.RecieveQuestion("What is Mediator Pattern?", student);

Console.ReadLine();