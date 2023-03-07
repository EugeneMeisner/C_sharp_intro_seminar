// Write a program that takes two numbers as input and outputs which number
// is greater and which is less.
// a = 5; b=7 -> max=7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter a number a: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number b: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 > num2)
{
    Console.WriteLine("a=" + num1 + ";" + "b=" + num2 + "->" + "max=" + num1);
}
else if (num1 < num2)
{
    Console.WriteLine("a=" + num1 + ";" + "b=" + num2 + "->" + "max=" + num2);
}
else
{
    num1 = num2;
    Console.WriteLine("Error, a=b number are quol");
}