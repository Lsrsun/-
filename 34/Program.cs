// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
        array[n] = Random.Shared.Next(100, 1000);
    }
    Console.WriteLine(string.Join(",", array));
    return array;
}

int NumberPositive (int[] array)
{
    int Sum = 0;
    for(int n = 0; n < array.Length; n++)
    {
        int even = array[n];
        if (even % 2 == 0) 
            Sum = Sum + 1;
    }
    return Sum;
}
int[] array = InputArray();
FillArray(array);
int Sum = NumberPositive(array);
Console.WriteLine($"Количество положительных элементов массива: {Sum}");
