// Write a program that takes three numbers as input and outputs 
// the maximum of these numbers.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Enter a number 1: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number 2: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number 3: ");
int num3 = int.Parse(Console.ReadLine()!);

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write(num1 + "," + num2 + "," + num3 + "->" + max);

