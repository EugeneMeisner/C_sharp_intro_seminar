// Write a program that accepts a three-digit number at the input and at the output
// show the last digit of that number. 

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int thNum = new Random().Next(100, 1000);    //[100, 999)
int result = TakeNum(thNum);
Console.WriteLine(result);