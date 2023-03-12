// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем


string msg = "Введите элемент";
int[] array = new int[8];
int i = 1;
int R = 1;
while(i < array.Length)
{
    Console.WriteLine($"{msg} {R}");
    array[i] = Convert.ToInt32(Console.ReadLine());
    R = R + 1;
    i = i + 1;
}

Console.WriteLine("Массив: " + string.Join(" ", array));



