namespace Paskaita03
{
    public class Uzduotis05
    {
        // Tema: Studentų pažymių analizė. Užduotis: Parašykite C# programą, kuri atliktų šiuos veiksmus:
        // Sukurtų masyvą iš n studentų pažymių (atsitiktinių skaičių intervale nuo 1 iki 10).
        // Naudotų ciklus, kad:
        // Atspausdintų visus pažymius.
        // Apskaičiuotų ir atspausdintų pažymių vidurkį.
        // Apskaičiuotų ir atspausdintų didžiausią ir mažiausią pažymį.
        // Parašytų funkciją, kuri priimtų masyvą kaip parametrą ir grąžintų visų teigiamų pažymių skaičių.
        // Parašytų funkciją, kuri priimtų masyvą kaip parametrą ir grąžintų visų pažymių sumą.
        // Teigiamas skaitosi 5 ir daugiau

        public static void Main(string[] args)
        {
            Random random = new Random();

            // Get amount of students n from user
            int n;
            bool isInt;
            do
            {
                Console.WriteLine("Iveskite studentu skaiciu. ");
                isInt = int.TryParse(Console.ReadLine(), out n);
            }
            while (!isInt || n < 1);

            // Create and populate array of length n with random marks from 1 to 10
            int[] studentMarks = new int[n];
            for (int i = 0; i < n; i++)
            {
                studentMarks[i] = random.Next(1, 11);
            }

            // Print all marks
            Console.WriteLine("Studentu pazymiai: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(studentMarks[i]);
            }
            Console.WriteLine();

            // Print average mark
            Console.WriteLine("Studentu pazymiu vidurkis: " + studentMarks.Average() + "\n");

            // Print highest and lowest marks
            Console.WriteLine($"Didziausias pazimys: {studentMarks.Max()}\nMaziausias pazymys: {studentMarks.Min()}\n");

            // Print amount of marks over 4
            Console.WriteLine($"Is {n} studentu tiek gavo teigiamus (5+) pazymius: {Marks5AndUp(studentMarks)}\n");

            // Print sum of all marks
            Console.WriteLine($"Visu {n} studentu pazymiu suma: {SumAllMarks(studentMarks)}\n");
        }

        private static int Marks5AndUp(int[] marks)
        {
            int k = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > 4)
                    k++;
            }

            return k;
        }

        private static int SumAllMarks(int[] marks)
        {
            int sum = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > 4)
                    sum += marks[i];
            }

            return sum;
        }
    }
}
