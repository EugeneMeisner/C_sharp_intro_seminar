// Write a program that outputs an array of 8 elements filled with zeros and
// units in random order.
int GenerateRandom()
{
    int random = new Random().Next(2);  //[0,1)
    return random;
}
void PrintArr(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int[] RandArr()
{
    int[] arr = new int[8];
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = GenerateRandom();
    }
    return arr;
}
PrintArr(RandArr());