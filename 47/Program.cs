// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int EnteringValues(string msg)
{
    Console.WriteLine($"{msg}");
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}

int m = EnteringValues("Введите количество строк");
int n = EnteringValues("Введите количество столбцов");
int LeftBorder = EnteringValues("Введите минимальное значение для элементов массива");
int RightBorder = EnteringValues("Введите максимальное значение для элементов массива");

double[,] matrix = new double[m,n];

void PrintArray(double[,] table, int m, int n)
{
 for (int i = 0; i < m; i++)
 {
    for (int j = 0; j < n; j++)
    {
    Console.Write($"{table[i, j]} ");
    }
 Console.WriteLine();
 }
}


void FillArray(double[,] table, int L, int R)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        table[i,j] = Random.Shared.Next(L, R) + Random.Shared.NextDouble();
        }
    }
}

FillArray(matrix, LeftBorder, RightBorder);
PrintArray(matrix, m, n);
