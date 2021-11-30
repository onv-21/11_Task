// See https://aka.ms/new-console-template for more information
Console.WriteLine("Линейное уравнение имеет вид 0=k*x+b");
Console.WriteLine("Введите значения 'k' и 'b'");
LinearEquation linearEquation = new LinearEquation(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
linearEquation.Root();
struct LinearEquation
{
    double x;
    double k;
    double b;

    public LinearEquation( double k, double b):this()
    {
       this.k = k;
        this.b = b;
    }
    public void Root()
    {
        x = -(b / k);
        Console.WriteLine("'x' равен {0}", x);
    }
}