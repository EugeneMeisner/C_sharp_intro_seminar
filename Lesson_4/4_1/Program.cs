// Write a program that accepts
// a number as input and returns the number of digits in the number.
void Print(string msg)
{
    Console.WriteLine(msg);
}
int Parse()
{
    int parse = int.Parse(Console.ReadLine()!);
    return parse;
}
int Calc(int num)
{
    int i = 0;

   while(num>0)
    {
       num /= 10;
       i++;
       
    }
    return i;
}
Print("Enter a number: ");
int val = Parse();
int result = Calc(val);
Print($"{result}"); 