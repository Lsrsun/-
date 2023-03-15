// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

double SumElements(int[] array)
{
    double Sum = 0;
    for (int n = 1; n < array.Length; n = n + 2)
    {
        Sum = Sum + array[n];
    }
    return Sum;
}

int[] array = InputArray();
FillArray(array);
double Sum = SumElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {Sum}");