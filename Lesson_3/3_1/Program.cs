// Write a programm, that by given number, shows the range possible point coordinates in this quarters.
void GetQuarters()
{
    Console.WriteLine("Enter a quarter number :");
    int q = int.Parse(Console.ReadLine()!);
    if (q < 1 || q > 4)
    {
        Console.WriteLine("Error,no such quarter!");
    }
    else
    {
        switch (q)
        {
            case 1:
                System.Console.WriteLine("x>0,y>0");
                break;
            case 2:
                System.Console.WriteLine("x<0,y>0");
                break;
            case 3:
                System.Console.WriteLine("x<0,y<0");
                break;
            case 4:
                System.Console.WriteLine("x>0,y<0");
                break;
            default:
                Console.WriteLine("Error,no such quarter!");
                break;
        }
    }
}
GetQuarters();


