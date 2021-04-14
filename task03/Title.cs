using System;

namespace task03
{
    public class Title
    {
        private readonly string _title;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_title);
            Console.ResetColor();
        }
        public Title(string title)
        {
            this._title = title;
        }
    }
}
