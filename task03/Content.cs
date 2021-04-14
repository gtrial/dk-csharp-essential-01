using System;

namespace task03
{
    public class Content
    {
        private readonly string _content;
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_content);
            Console.ResetColor();
        }
        public Content(string content)
        {
            this._content = content;
        }
    }
}
