namespace lab3t11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние в километрах: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах: ");
            double ft = double.Parse(Console.ReadLine());
            double kmToM = km * 1000;
            double ftToM = ft * 0.305;
            string result = kmToM < ftToM ? "Километровое расстояние меньше" : "Расстояние в футах меньше";
            Console.WriteLine(result);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
