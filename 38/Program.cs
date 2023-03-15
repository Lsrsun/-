//  Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] InputArray ()
{
    Console.WriteLine("Введите количество элементов массива: ");
    int i = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[i];
    return array;
}

int[] FillArray (int[] array)
{
    for(int n = 0; n < array.Length; n++)
    {
        array[n] = Random.Shared.Next();
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}

int MaxMinusMin (int[] array)
{
    int Min = array[0];
    int Max = array[0];
    for (int n = 0; n < array.Length; n++)
    {
        if (array[n] > Max) Max = array[n];
        if (array[n] < Min) Min = array[n];
    }
    int diff = Max - Min;
    return diff;
}

int[] array = InputArray();
FillArray(array);
int diff = MaxMinusMin(array);
Console.WriteLine(diff);


