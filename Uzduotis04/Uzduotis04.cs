namespace Paskaita03
{
    public class Uzduotis04
    {
        // 4. Sukurkite metodą, kuris suskaičiuoja, kiek vidutiniškai keleivių k važiuoja į Vilnių
        // viename traukinio vagone, jei žinomas traukinio keleivių skaičius n, keleivių, vykstančių
        // ne į Vilnių skaičius m ir vagonų skaičius v.
        // galite naudoti random skaicius:
        //      (int)(Math.random()*50)
        public static void Main(string[] args)
        {
            Random random = new Random();

            int vilniusPassengerCount;
            int allPassengerCount = (int)(random.NextDouble() * 50);
            do
            {
                vilniusPassengerCount = (int)(random.NextDouble() * 50);
            }
            while (vilniusPassengerCount > allPassengerCount);

            int trainCarCount = (int)(random.NextDouble() * 50);

            Console.WriteLine($"Traukiniu su {trainCarCount} vagonu vaziuoja {allPassengerCount} keleiv., is kuriu {vilniusPassengerCount} vaziuoja i Vilniu." +
                $"\nViename vagone vaziuoja vidutiniskai {AvgVilniusPassengerCountPerTrainCar(allPassengerCount, vilniusPassengerCount, trainCarCount):0.00} keleiv.");
        }

        private static double AvgVilniusPassengerCountPerTrainCar(int n, int m, int v)
        {
            double k = ((double)n - (double)m) / (double)v;
            return k;
        }
    }
}
