namespace Paskaita03
{
    public class Program
    {
        // Patobilinti AddBook metodą, kad jis praplėstų masyvo dydį kaskart pridėdamas naują knygą.
        // Sukurti funkciją RemoveBook(int index) kuri pašalina knyga iš masyvo pagal norodytą index'ą
        // ir sumažina masyvą, nepalieka tarpo, paslenka knygas taip kad nebūtų null elementų.
        // (Masyvas inicializavus klasę Library turi būti[0])
        public static void Main(string[] args)
        {
            Book book1 = new("Balta drobule", "Antanas Skema", 192);
            Book book2 = new("Liudna Pasaka", "Jonas Biliunas", 278);
            Book book3 = new("Altoriu sesely", "Vincas Mykolaitis-Putinas", 408);

            Library library = new Library();

            // Testing AddBook
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Testing GetBooksByAuthor and PrintBooksArray
            library.PrintBooksArray(library.GetBooksByAuthor(book1.Author));
            library.PrintBooksArray(library.GetBooksByAuthor(book2.Author));
            library.PrintBooksArray(library.GetBooksByAuthor(book3.Author));

            Console.WriteLine();
            // Testing RemoveBook with PrintBooksArray
            library.RemoveBook(1);
            library.PrintBooksArray(library.books);
        }
    }
}
