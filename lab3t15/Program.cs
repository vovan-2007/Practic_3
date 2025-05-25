namespace lab3t15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            bool axb = b % a == 0;
            bool bxa = a % b == 0;
            Console.WriteLine($"Число a является делителем числа b: {axb}");
            Console.WriteLine($"Число b является делителем числа a: {bxa}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
