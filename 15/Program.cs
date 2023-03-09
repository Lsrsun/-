// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int N = Convert.ToInt32(Console.ReadLine());
switch (N)
{
    case 1:
        Console.WriteLine("Не выходной");
        break;
    case 2:
        Console.WriteLine("Не выходной");
        break;
    case 3:
        Console.WriteLine("Не выходной");
        break;
    case 4:
        Console.WriteLine("Не выходной");
        break;
    case 5:
        Console.WriteLine("Почти выходной-пятница");
        break;
    case 6:
        Console.WriteLine("Выходной!");
        break;
    case 7:
        Console.WriteLine("Выходной");
        break;
};
if (N > 7) Console.WriteLine("Такого дня недели не существует");