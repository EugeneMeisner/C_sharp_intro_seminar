// Write a program that outputs
// random three digit number and remove the second digit
// this number.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int RandomNum()
{
    int RandomNum = new Random().Next(99, 1000);
    return RandomNum;
}
int FirstNum(int arg)
{
    int cin1 = arg / 100;
    return cin1;
}
int SecondNum(int arg)
{
    int cin2 = arg % 10;
    return cin2;
}
int OperationNum(int arg1, int arg2)
{
    int cin3 = arg1 * 10 + arg2;
    return cin3;

}
void PrintMessage(int arg)
{
    Console.WriteLine(arg);
}
int random = RandomNum();
PrintMessage(random);
int firstNum = FirstNum(random);
int secondNum = SecondNum(random);
int result=OperationNum(firstNum, secondNum);
PrintMessage(result);