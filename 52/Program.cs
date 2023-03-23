// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int EnteringValues(string msg)
{
    Console.WriteLine($"{msg}");
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}

void PrintArray(int[,] table, int m, int n)
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


void FillArray(int[,] table, int L, int R, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        table[i,j] = Random.Shared.Next(L, R);
        }
    }
}

void Avarage(int[,] table, int n)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < table.GetLength(0); i++)
        {
            avarage = (avarage + table[i,j]);
        }
        avarage = avarage / n;
        Console.Write($"Среднее арифметическое столбца {j+1}: {avarage}; ");
    }
Console.WriteLine();
}

int m = EnteringValues("Введите количество строк");
int n = EnteringValues("Введите количество столбцов");
int LeftBorder = EnteringValues("Введите минимальное значение для элементов массива");
int RightBorder = EnteringValues("Введите максимальное значение для элементов массива");

int[,] matrix = new int[m,n];

FillArray(matrix, LeftBorder, RightBorder, m, n);
PrintArray(matrix, m, n);
Avarage(matrix, n);