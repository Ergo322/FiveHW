void EvenNum()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine($"чётных чисел {count}");
}
EvenNum();