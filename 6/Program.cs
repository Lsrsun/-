﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());
int M = A% 2;
if (M == 0)
{
    Console.WriteLine(A + " - четное");
}
else Console.WriteLine(A + " - нечетное");