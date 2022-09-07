void SumOddNum()
{
    int[] array = new int[9];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");

    }
    int sum = 0;
    int a = array.Length;
    int[] f = new int[a];
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 == 1)
            sum = sum + array[j];
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях = {sum}");
}
SumOddNum();