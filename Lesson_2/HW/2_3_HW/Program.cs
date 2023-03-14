// // Write a program that displays the third digit of a given number, 
//or reports that there is no third digit.
// 645 -> 5
// 78 -> no third digit
// 32679 -> 6
int RandomNum()
{
    int RandomNum = new Random().Next(10, 1000);
    return RandomNum;
}
int ComparsionNum(int arg)
{
    if (arg>99)
    {
        arg=arg/100;   
        return arg;    
    }
    else
    return arg;
}
void PrintMessage(int arg)
{
    if(arg<10)
    {
        Console.WriteLine(arg);
    }   
    else
    Console.WriteLine("no third digit");
}
int random = RandomNum();
int receivedNum = ComparsionNum(random);
PrintMessage(receivedNum);




