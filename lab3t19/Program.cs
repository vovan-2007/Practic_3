namespace lab3t19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день года (1-365): ");
            int k = int.Parse(Console.ReadLine());
            int WeekDay = (k - 1) % 7;
            bool isWeekend = WeekDay == 5 || WeekDay == 6;
            string day = WeekDay == 5 || WeekDay == 6 ? "суббота" : "воскресенье";
            Console.WriteLine($"День {k} является выходным: {isWeekend}");
            Console.WriteLine($"День конкретно {day}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
