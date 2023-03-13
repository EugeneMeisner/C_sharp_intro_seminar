// Write a program that takes a three-digit number 
// as input and outputs the second digit of that number.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void PrintMessage(string message)
{
    Console.WriteLine(message);
}
int InputNum()
{
     return int.Parse(Console.ReadLine());
}
int FirstNum(int arg)
{
    int getfirst =arg / 10;
    return getfirst;
}
int SecondNum(int arg)
{
    int getSecond =arg % 10;
    return getSecond;
}

PrintMessage("Enter a three-digit numbers: ");
int num = InputNum();
int delFirst = FirstNum(num);
int delSecond= SecondNum(delFirst);
PrintMessage("second digit of that number: " + delSecond);
PrintMessage("==============================");