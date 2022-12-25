// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

namespace task21DZ
{
    internal class Program
    {
        public Program()
        {
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string number = Console.ReadLine();
            int len = number.Length;

            if (len == 5)
            {
                if (number[0] == number[4] && number[1] == number[3])
                {
                    Console.WriteLine($"{number} - Палиндром");
                }
                else
                {
                    Console.WriteLine($"{number} - Не палиндром");
                }
            }
            else
            {
                Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
            }
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}