namespace Paskaita03
{
    // Sukurkite klasę Book, kuri turės šias savybes:
    // Title(string)
    // Author(string)
    // Pages(int)

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public override string ToString()
        {
            return $"{Title} {Author} {Pages}";
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
