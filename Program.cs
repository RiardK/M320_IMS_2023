namespace OO_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
using System;

class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }

        public static int ReadInt(string prompt)
        {
            int result;
            do
            {
                Console.Write(prompt);
            } while (!int.TryParse(Console.ReadLine(), out result) || result <= 0);
            return result;
        }

        public static void ShowResult(string operation, int a, int b, int result)
        {
            Console.WriteLine($"{operation} von {a} und {b} ist {result}");
        }

        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
                return a;
            return Calc_ggT_r(b, a % b);
        }

        public static double CalcArithmeticMean(int[] numbers)
        {
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        public static int FindSmallestValue(int[] numbers)
        {
            int smallest = numbers[0];
            foreach (int num in numbers)
            {
                if (num < smallest)
                    smallest = num;
            }
            return smallest;
        }

        public static int FindLargestValue(int[] numbers)
        {
            int largest = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largest)
                    largest = num;
            }
            return largest;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void ReverseArray(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                Swap(ref array[left], ref array[right]);
                left++;
                right--;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. ggT berechnen");
                Console.WriteLine("2. kgV berechnen");
                Console.WriteLine("3. Array-Funktionen");
                Console.WriteLine("4. Beenden");
                Console.Write("Option wählen: ");

                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int result = MyMath.Calc_ggT(a, b);
                    MyMath.ShowResult("ggT", a, b, result);
                }
                else if (option == 2)
                {
                    int a = MyMath.ReadInt("Geben Sie die erste Zahl ein: ");
                    int b = MyMath.ReadInt("Geben Sie die zweite Zahl ein: ");
                    int result = MyMath.Calc_kgV(a, b);
                    MyMath.ShowResult("kgV", a, b, result);
                }
                else if (option == 3)
                {
                    int arraySize = MyMath.ReadInt("Geben Sie die Größe des Arrays ein: ");
                    int[] numbers = new int[arraySize];
                    for (int i = 0; i < arraySize; i++)
                    {
                        numbers[i] = MyMath.ReadInt($"Geben Sie die Zahl an Index {i} ein: ");
                    }

                    Console.WriteLine($"Arithmetischer Mittelwert: {MyMath.CalcArithmeticMean(numbers)}");
                    Console.WriteLine($"Kleinster Wert: {MyMath.FindSmallestValue(numbers)}");
                    Console.WriteLine($"Größter Wert: {MyMath.FindLargestValue(numbers)}");

                    MyMath.ReverseArray(numbers);
                    Console.WriteLine("Umgekehrtes Array:");
                    foreach (int num in numbers)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine();
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Option!");
                }

                Console.WriteLine();
            }
        }
    }