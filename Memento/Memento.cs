using System.Reflection.Metadata.Ecma335;

namespace Memento
{
    public class Memento(string? ısbn, string? title, string? author, DateTime lastEdited)
    {
        public string? Isbn { get; set; } = ısbn;
        public string? Title { get; set; } = title;
        public string? Author { get; set; } = author;
        public DateTime LastEdited { get; set; } = lastEdited;
    }

    public class Book
    {
        private string? _title;
        private string? _author;
        private string? _isbn;
        private DateTime _lastEdited;


        public string? Title { get => _title; set { _title = value; SetLastEdited(); } }

        public string? Author { get => _author; set { _author = value; SetLastEdited(); } }

        public string? Isbn { get => _isbn; set { _isbn = value; SetLastEdited(); } }

        private DateTime LastEdited;

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateMemento()
        {
            return new Memento(_isbn, _title, _author, _lastEdited);
        }

        public void RestoreMemento(Memento memento)
        {
            _isbn = memento.Isbn;
            _title = memento.Title;
            _author = memento.Author;
            _lastEdited = memento.LastEdited;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"ISBN: {_isbn}");
            Console.WriteLine($"Last Edited: {_lastEdited}");
            Console.WriteLine("-------------------------------------");
        }
    }

    public class CareTaker
    {
        public Memento? Memento { get; set; }
    }
}
