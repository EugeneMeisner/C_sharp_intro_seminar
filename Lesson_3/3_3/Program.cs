// Write a program that takes a number (N) as input
// and produces a table squares of numbers from 1 to N.
void PrintMessage(string message)
{
    System.Console.WriteLine(message);
}
int ReadNum()
{
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void TableSquares(int arg)
{
    if (arg != 0)
    {
        PrintMessage("Squares number " + arg + " " + " " + ":");
        int i = 1;
        while (i <= arg)
        {
           Console.WriteLine(Math.Pow(i,2));
           i++;
           //int n = i * i;
           //Console.WriteLine("" + n);
            //i++;
            
        }
        return;
    }
    else
        PrintMessage("Squares number " + arg + " " + "=" + " " + arg);
    return;
}
PrintMessage("Enter N: ");
int N = ReadNum();
TableSquares(N);