// Write a program that accepts the input is 
// a number (N) and produces a table of cubes of numbers from 1 to N.
void PrintMessage(string message)
{
    System.Console.WriteLine(message);
}
int ReadNum()
{
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
void CubeTable(int arg)
{
    if (arg > 0)
    {
        PrintMessage("Squares number " + arg + " " + " " + ":");
        int i = 1;
        while (i <= arg)
        {
            Console.WriteLine(Math.Pow(i, 3));
            i++;
        }
        return;
    }

    else if (arg < 0)
    {

        PrintMessage("Squares number " + arg + " " + " " + ":");
        arg=(arg)*(-1);
        int n = 1;
        while (n <= arg)
        {
            Console.WriteLine(Math.Pow(n, 3));
            n++;
            
        }
        return;
    }
    else
        PrintMessage("Squares number " + arg + " " + "=" + " " + arg);
    return;
}
PrintMessage("Enter N: ");
int N = ReadNum();
CubeTable(N);
