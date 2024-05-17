namespace Paskaita03
{
    public class Uzduotis02
    {
        // 2. Sukurkite metodą, kuris pagal šiuo metu esančių valandų bei minučių skaičių
        // (naudokite parametrus hour ir minute iš DateTime) apskaičiuoja kiek minučių ir sekundžių praėjo po vidurnakčio.
        // Pvz.: "Siuo metu yra 14val. 33min., tai praejo 873 minutes (arba 52380 sekundziu) po vidurnakcio."
        // galime naudoti tokius parametrus iš DateTime tipo objekto:
        // DateTime.Now.Hour
        // DateTime.Now.Minute
        public static void Main(string[] args)
        {
            MinSecAfterMidnight(DateTime.Now.Hour, DateTime.Now.Minute);
        }

        private static void MinSecAfterMidnight(int hours, int minutes)
        {
            Console.WriteLine($"Siuo metu yra {hours} val. {minutes} min.\nPo vidurnakcio praejo {hours * 60 + minutes} min. arba {hours * 3600 + minutes * 60} sek.");
        }
    }
}
