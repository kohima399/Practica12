namespace VS_Code;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введи X = ");
        double x = Convert.ToDouble(Console.ReadLine());
        double F = (Math.Sin(x) - Math.Cos(x)) / 5;
        Console.WriteLine($"F = {F}.");
        Console.ReadKey();
    }
}
