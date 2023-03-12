// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Number(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A = Number("Введите число А");
int B = Number("Введите число B");

int result = A;

for (int i = 2; i <= B; i++)
{
    result = result * A;
}

Console.WriteLine(result);