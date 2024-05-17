namespace Paskaita03
{
    public class Uzduotis01
    {
        // 1. Sukurkite metodą, kuris priima metų skaičių ir atspausdina,
        // kiek mėnesių, dienų ir valandų tai yra. Tarkime kad metai turi 365 dienas.
        // Pvz.: "16 metu, tai: 192 menesiu, 5840 dienu, 140160 valandu."
        public static void Main(string[] args)
        {
            int years;
            bool isInt;
            do
            {
                Console.WriteLine("Iveskite metus (teigiama sveikaji skaiciu), kuriuos norite isskaidyti i menesius, dienas ir valandas");
                isInt = int.TryParse(Console.ReadLine(), out years);
            }
            while (!isInt || years < 1);

            YearsIntoMonthsDaysHours(years);
        }

        private static void YearsIntoMonthsDaysHours(int years)
        {
            Console.WriteLine($"{years} metai(-u) yra {years * 12} menesiu arba {years * 365} dienu, arba {years * 365 * 24} valandu.");
        }
    }
}
