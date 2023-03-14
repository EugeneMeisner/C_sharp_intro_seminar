// Write a program that accepts
// input a digit representing the day of the week, and checks if
// Is this day a holiday?
// 6 -> да
// 7 -> да
// 1 -> нет
void PrintMessage(string message)
{
    Console.WriteLine(message);
}
int InputDay()
{
    return int.Parse(Console.ReadLine()!);
}
void ComparsionNum(int arg)
{

    if (arg == 6 ^ arg == 7)
    {
        Console.WriteLine("Yes");
        return;
    }
    else if (arg == 1 ^ arg == 2 ^ arg == 3 ^ arg == 4 ^ arg == 5)
    {
        Console.WriteLine("No");
        return;
    }

    else

        Console.WriteLine("Error.Please enter a number from 1 to 7");

}
PrintMessage("Please enter input a digit representing the day of the week: ");
int day = InputDay();
System.Console.WriteLine(day);
ComparsionNum(day);
