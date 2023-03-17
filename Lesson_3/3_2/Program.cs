// Write a program, that takes coordinates as input 
// two points and finds the distance between them in 2D spac

double Calculation(int x1, int y1, int x2, int y2)
{

    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 3);
}
void PrintResult(double res)
{
    System.Console.WriteLine(res);
}
Console.Write("x1=");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("y1=");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("x2=");
int a2 = int.Parse(Console.ReadLine()!);
Console.Write("y2=");
int b2 = int.Parse(Console.ReadLine()!);
double result = Calculation(a1,b1,a2,b2);
PrintResult(result);