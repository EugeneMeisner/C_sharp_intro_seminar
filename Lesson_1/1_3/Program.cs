// Write a program that takes one number as input
// (N), and the output shows all integers between -N and N.
Console.WriteLine("Enter N: ");
int num = int.Parse(Console.ReadLine()!);
int count = -num;
while (count != num)
{
    Console.WriteLine(count); 
    if(num<0)
    {
        count--;
    }
    else count++;

}
