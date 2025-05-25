namespace lab3t17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            bool vyear = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);
            Console.WriteLine($"Год {year} високосный: {vyear}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
