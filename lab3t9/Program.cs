﻿namespace lab3t9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double max = Math.Max(Math.Max(a, b), c);
            double min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Наибольшее число: {max}");
            Console.WriteLine($"Наименьшее число: {min}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
