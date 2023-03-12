// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int N)
{
    int a = 0; 
    int i = 1; 
    int M = 0;
    int Sum = 0;
    int P = N;
    while (N > 10)
    {   
        N = N / 10;
        i = i + 1;
    }
    while (a < i)
    {
        M = P % 10;
        P = P / 10;
        Sum = Sum + M;
        a = a + 1;
    }
return Sum;
}


int M = SumOfNumbers(A);
Console.WriteLine(M);
