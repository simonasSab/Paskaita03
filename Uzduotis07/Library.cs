namespace Paskaita03
{
    // Sukurkite klasę Library, kuri turės:
    // Book masyvą
    // Funkciją AddBook(Book book), kuri pridės knygą į nurodytą vietą į masyvą
    // Funkciją GetBooksByAuthor(string author), kuri grąžins visas tam tikro autoriaus knygas
    // Funckija kuri atspausdina GetBooksByAuthor grazinta masyva

    // Patobilinti AddBook metodą, kad jis praplėstų masyvo dydį kaskart pridėdamas naują knygą.
    // Sukurti funkciją RemoveBook(int index) kuri pašalina knyga iš masyvo pagal norodytą index'ą
    // ir sumažina masyvą, nepalieka tarpo, paslenka knygas taip kad nebūtų null elementų.
    // (Masyvas inicializavus klasę Library turi būti[0])

    public class Library
    {
        public Book[] books { get; set; }
        public int booksLength = 0;

        public Library()
        {
            books = new Book[booksLength];
        }

        public void AddBook(Book book)
        {
            Book[] oldBooks = books;
            booksLength++;
            books = new Book[booksLength];
            for (int i = 0; i < oldBooks.Length; i++)
            {
                books[i] = oldBooks[i];
            }
            books[booksLength - 1] = book;
        }

        public Book[] GetBooksByAuthor(string author)
        {
            Book[] booksOut = new Book[booksLength];

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].Author == author)
                    booksOut[i] = books[i];
            }
            return booksOut;
        }

        public void PrintBooksArray(Book[] books)
        {
            for (int i = 0; i < books.Length;i++)
            {
                if (books[i] != null)
                    Console.WriteLine(books[i]);
            }
        }

        public void RemoveBook(int index)
        {
            books[index] = null;
            Book[] oldBooks = books;
            booksLength--;
            books = new Book[booksLength];
            for (int i = 0; i < index; i++)
            {
                books[i] = oldBooks[i];
            }
            for (int i = index + 1; i < oldBooks.Length; i++)
            {
                books[i - 1] = oldBooks[i];
            }
        }
    }
}
