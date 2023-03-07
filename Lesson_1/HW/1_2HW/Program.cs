// Write a program that takes a number as input and outputs whether the number is even 
// (whether it is divisible by two without a remainder).
// 4 -> yes
// -3 -> no
// 7 -> no
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num %= 2;
if (num1 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}