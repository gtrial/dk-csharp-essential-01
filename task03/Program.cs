namespace task03
{
    internal static class Program
    {
        private static void Main()
        {
            Book book = new("title1", "author1", "content1");
            book.Title.Show();
            book.Author.Show();
            book.Content.Show();
        }
    }
}
