namespace Paskaita03
{
    public class Uzduotis06
    {
        // Sukurkite funkciją kuriai paduodame du double skaicius bei matematinio veiksmo (+,-,/,*)
        // operatorių kaip string ir pagal tą operatorių funkcija atlika veiksmą ir grąžina rezultatą
        public static void Main(string[] args)
        {
            double double1 = 0;
            double double2 = 0;
            string operand = "";

            // Get first double
            bool isDouble;
            do
            {
                Console.WriteLine("Iveskite pirmaji bet koki skaiciu ...");
                isDouble = double.TryParse(Console.ReadLine(), out double1);
            }
            while (!isDouble);

            // Get second double
            do
            {
                Console.WriteLine("Iveskite antraji bet koki skaiciu ...");
                isDouble = double.TryParse(Console.ReadLine(), out double2);
            }
            while (!isDouble);

            do
            {
                Console.WriteLine("Iveskite viena operacijos simboli (+, -, *, /) ...");
                operand = Console.ReadLine();
            }
            while (operand.Length != 1);

            Console.WriteLine($"{double1} {operand} {double2} = {Calculator(double1, double2, operand):.000}");
        }

        private static double Calculator(double double1, double double2, string operand)
        {
            switch (operand)
            {
                case "+":
                    return double1 + double2;
                case "-":
                    return double1 - double2;
                case "*":
                    return double1 * double2;
                case "/":
                    return double1 / double2;
                default:
                    Console.WriteLine("KLAIDA: Funckija gavo kitokia reiksme nei (+, -, *, /)");
                    return 0;
            }
        }
    }
}
