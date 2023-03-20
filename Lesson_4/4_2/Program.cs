// Write a program that takes the number N as input and outputs
// item numbers from 1 to N.
void PrintMsg(string msg)
{
    Console.WriteLine(msg);
}
int InputRead()
{
    int n = int.Parse(Console.ReadLine()!);
    return n;
}
int CalcRes(int num)
{
    int res = 1;
    for (int j = 1; j <= num; j++)
    {
        res *= j ;
    }
    return res;
}
PrintMsg("Please enter a number N!: ");
int n = InputRead();
int result = CalcRes(n);
PrintMsg($"{result}");