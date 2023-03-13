//  Write a program that outputs random number from the segment [10, 99] and shows
// the largest digit of the number.
Console.Clear();
int RandomGenerate()
{
    int RandomNum = new Random().Next(10, 100);
    return RandomNum;
}
int FirstNum(int arg1)
{
    return arg1 / 10;
}
int SecondNum(int arg2)
{
    return arg2 % 10;
}
int comparsion(int arg1, int arg2)
{
    if (arg1 > arg2)
    {
        return arg1;
    }
    return arg2;
}
void PrintNumber(string message)
{
    Console.WriteLine(message);
}

int generate = RandomGenerate();
PrintNumber("Random number: " + generate);
int n1_0 = FirstNum(generate);
int num2 = generate;
int n2_0 = SecondNum(num2);
int max = comparsion(n1_0, n2_0);
PrintNumber("Largest digit of the number: " + max);
