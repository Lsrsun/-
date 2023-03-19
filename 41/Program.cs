// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputAndCheck(string msg)
{
    Console.WriteLine("Введите количество целых чисел: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int number = 0;
    int Sum = 0;
    int i = 1;
    while (i <= M)
    {
        number = number + 1;
        Console.WriteLine($"{msg} {number}");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N > 0) Sum = Sum + 1;
        i++;
    }
    return Sum;
}

int Sum = InputAndCheck("Введите число");
Console.WriteLine($"Количество положительных чисел: {Sum}");
