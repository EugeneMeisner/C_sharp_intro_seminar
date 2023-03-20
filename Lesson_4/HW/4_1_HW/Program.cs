// Write a loop that takes as input
// two numbers (A and B) and raises the number A to natural degree B. 
void PrintMsg(string msg)
{
    System.Console.WriteLine(msg);
}
void PrintMsgInt(int msg)
{
    System.Console.WriteLine(msg);
}
int ReadInput()
{
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int GetNumbers()
{   PrintMsg("Please enter A :");
    int a = ReadInput();
    PrintMsg("Please enter B :");
    int b = ReadInput();
    int res=1;
    for (int i = 0; i < b; i++)
    {
        res*=a;
    }
    return res;
}

PrintMsgInt(GetNumbers());