void DifferenceMinMax()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}");
    }
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    int raz = max - min;

    Console.Write($"Разность между макс и мин ровна: {raz}");
}
DifferenceMinMax();