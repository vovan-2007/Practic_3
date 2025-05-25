namespace lab3t16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double w1 = 5;
            double h1 = 4;
            double x2 = 1;
            double y2 = 1;
            double w2 = 6;
            double h2 = 3;
            double x1_max = x1 + w1;
            double y1_max = y1 + h1;
            double x2_max = x2 + w2;
            double y2_max = y2 + h2;
            bool FinS = x1 >= x2 && y1 >= y2 && x1_max <= x2_max && y1_max <= y2_max;
            Console.WriteLine($"a) Все точки первого прямоугольника принадлежат второму: {FinS}");
            bool SinF = x2 >= x1 && y2 >= y1 && x2_max <= x1_max && y2_max <= y1_max;
            bool any = FinS || SinF;
            Console.WriteLine($"б) Все точки второго прямоугольника принадлежат первому: {any}");
            bool noOver = x1_max < x2 || x2_max < x1 || y1_max < y2 || y2_max < y1;
            bool x = !noOver;
            Console.WriteLine($"в) Прямоугольники пересекаются: {x}");
            Console.WriteLine("Нажмите на любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
