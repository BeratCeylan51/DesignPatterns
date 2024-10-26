namespace Bridge
{
    public abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved");
        }

        public abstract void Send(Body body);
    }

    public class Body
    {
        public string? Title { get; set; }
        public string? Text { get; set; }
    }

    public class SmsSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine($"SMS sent: {body.Title} - {body.Text}");
        }
    }

    public class EmailSender : MessageSenderBase
    {
        public override void Send(Body body)
        {
            Console.WriteLine($"Email sent: {body.Title} - {body.Text}");
        }
    }

    public class CustomerManager
    {
        public required MessageSenderBase MessageSenderBase { get; set; }

        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new() { Title = "Customer Updated", Text = "Customer has been updated" });
            Console.WriteLine("Customer updated");
        }
    }
}
