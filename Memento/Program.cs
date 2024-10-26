using Memento;

Book book = new()
{
    Isbn = "12345",
    Title = "Sefiller",
    Author = "Victor Hugo"
};

book.Show();
CareTaker history = new();
history.Memento = book.CreateMemento();

book.Isbn = "54321";
book.Title = "Les Miserables";

book.Show();

book.RestoreMemento(history.Memento);
book.Show();

Console.ReadLine();