using System;

namespace Calculator
{
    class Program
    {
        private static int lastResult = 0; // Interner Zustand für das Zwischenergebnis

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wähle eine Operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplikation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Beenden");
                Console.Write("Option: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Programm wird beendet.");
                    break;
                }

                int operand1;
                int operand2;

                if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
                {
                    Console.WriteLine("Ungültige Option. Bitte wähle 1, 2, 3, 4 oder 5.");
                    continue;
                }

                if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    Console.Write("Gib den ersten Operanden ein: ");
                    operand1 = int.Parse(Console.ReadLine());
                }
                else
                {
                    operand1 = lastResult; // Verwende das Zwischenergebnis
                }

                Console.Write("Gib den zweiten Operanden ein: ");
                operand2 = int.Parse(Console.ReadLine());

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(operand1, operand2);
                        break;
                    case 2:
                        result = Subtract(operand1, operand2);
                        break;
                    case 3:
                        result = Multiply(operand1, operand2);
                        break;
                    case 4:
                        result = Divide(operand1, operand2);
                        break;
                }

                lastResult = result; // Speichere das Zwischenergebnis
                Console.WriteLine($"Ergebnis: {result}\n");
            }
        }

        // Methoden für die Grundrechenoperationen
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division durch Null ist nicht erlaubt.");
                return 0;
            }
            return a / b;
        }
    }
}