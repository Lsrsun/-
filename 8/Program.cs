// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1;
int S = 0;
while (M <= N)
{
    S = M% 2;
        if (S == 0)
            Console.Write(M + " ");
    M = M + 1;    
}    