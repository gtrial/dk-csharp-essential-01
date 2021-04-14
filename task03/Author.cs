using System;

namespace task03
{
    public class Author
    {
        private readonly string _author;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_author);
            Console.ResetColor();
        }
        public Author(string author)
        {
            this._author = author;
        }
    }
}
