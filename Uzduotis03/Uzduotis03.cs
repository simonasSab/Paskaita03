namespace Paskaita03
{
    public class Uzduotis03
    {
        // 3. Sukurkite metodą, kuris suskaičiuoja, kiek knygų k vidutiniškai per metus perskaito
        // vienas mokyklos bibliotekos lankytojas. Žinomas vidutiniškai per mėnesį perskaitytų
        // knygų skaičius v ir vidutiniškai per metus apsilankiusių bibliotekoje skaičius n.
        // Galite naudoti random skaicius:
        //      (int)(Math.random()*50)
        public static void Main(string[] args)
        {
            Random random = new Random();

            int avgBooksPerMonth = (int)(random.NextDouble() * 50);
            int avgReadersPerYear = (int)(random.NextDouble() * 50);

            Console.WriteLine($"Per menesi vidutiniskai perskaitoma {avgBooksPerMonth} knygos(-u), o per metus vidutiniskai apsilanko {avgReadersPerYear} lankytojai(-u)." +
                $"\nVienas lankytojas per metus vidutiniskai perskaito {AvgBooksPerReaderPerYear(avgBooksPerMonth, avgReadersPerYear)} knygas(-u)");
        }

        private static int AvgBooksPerReaderPerYear(int v, int n)
        {
            int k = v * 12 / n;
            return k;
        }
    }
}
