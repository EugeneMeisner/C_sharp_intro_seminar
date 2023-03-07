// 1. Write a program that takes two numbers as input and checks if
// whether the first number is the square of the second.
Console.WriteLine("Please enter number 1: ");

int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Please enter number 2: ");

int num2 = int.Parse(Console.ReadLine()!);

if(num2 * num2 == num1)
{
    Console.WriteLine("the number 1 is the square of the number 2 ");
}
else
{
    Console.WriteLine("number 1 is not a square of number 2 ");
}