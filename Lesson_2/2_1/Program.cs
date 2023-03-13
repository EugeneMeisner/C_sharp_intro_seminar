//  Write a program that outputs random number from the segment [10, 99] and shows
// the largest digit of the number.
Console.Clear();
int RandomGenerate(int RandomNum)
{
    RandomNum = new Random().Next(10, 100);
    return RandomNum;
}
int FirstNum(int n1)
{
    return n1 / 10;
}
int SecondNum(int n2)
{
    return n2 % 10;
}
int comparsion(int maxn1, int maxn2)
{
    if (maxn1 > maxn2)
    {
        return maxn1;
    }
    return maxn2;
}
void PrintNumber(string message)
{
    Console.WriteLine(message);
}

int number = 0;
int generate = RandomGenerate(number);
int num1 = generate;
PrintNumber("Random number: "+generate);
int n1_0=FirstNum(num1);
int num2 = generate;
int n2_0 =SecondNum(num2);
int max = comparsion(n1_0, n2_0);
PrintNumber("Largest digit of the number: " + max);
