namespace task03
{
    public class Book
    {
        public Title Title { get; }
        public Author Author { get; }
        public Content Content { get; }

        public Book(string title, string author, string content)
        {
            Title = new Title(title);
            Author = new Author(author);
            Content = new Content(content);
        }
    }
}
