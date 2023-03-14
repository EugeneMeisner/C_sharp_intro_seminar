// 1. Write a program that takes as input the coordinates of a point (X and Y),
// moreover, X ≠ 0 or Y ≠ 0 and gives the number of a quarter of the plane,
// where this point is located.
void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Error. Please enter coordinates, not a zero!");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("quarter plane I");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("quarter plane II");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("quarter plane III");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("quarter plane IV");
    }
}
System.Console.WriteLine("Please enter: ");
int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quarters(num1, num2);