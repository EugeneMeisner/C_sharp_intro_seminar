// Write a program that takes a number (N) as input and outputs all even numbers from 1 to N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Enter a number N: ");
int num = int.Parse(Console.ReadLine()!);
int count = 2;

if (num > 1)
{
    while (count <= num)
    {
        Console.Write(count);
        count = count + 2;
    }
}
else
{
    Console.Write("error");
}
