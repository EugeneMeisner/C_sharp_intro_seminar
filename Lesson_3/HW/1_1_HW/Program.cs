// Write a program that accepts the input is a five-digit number
//  and checks if it is palindrom.
void PrintMessage(string message)
{
    System.Console.WriteLine(message);
}
int InputNumber()
{
    int get = int.Parse(Console.ReadLine()!);
    return get;
}
void Palindrom(int arg)
{
    int a1 = (arg % 10) * 10000;

    int a2 = ((arg % 100) / 10) * 1000;

    int a3 = ((arg % 1000) / 100) * 100;

    int a4 = ((arg / 1000) % 10) * 10;

    int a5 = arg / 10000;

    int result = a1 + a2 + a3 + a4 + a5;

    if (arg == result)
    {
        PrintMessage(result + " -> Yes");
        return;
    }
    else
        PrintMessage(result + " -> No");
    return;
}
PrintMessage("Enter a five-digit number :");
int num = InputNumber();
Palindrom(num);
