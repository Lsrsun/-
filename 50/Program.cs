// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// 17 -> такого числа в массиве нет

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


void FindElement(int[,] table, int m, int n)
{
    Console.WriteLine("Введите элемент для поиска");
    int N = Convert.ToInt32(Console.ReadLine());
    int Check = 0;
    int Row = 0;
    int Column = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (table[i,j] == N) 
            {
            Row = i;
            Column = j;
            Check = Check + 1; 
            } 
        }
    }
    if (Check == 0)
    {
    Console.WriteLine("Такого элемента не существует");
    }
    else 
    {
    Console.WriteLine($"Строка элемента: {Row}; столбец элемента: {Column}");
    }
}

int m = EnteringValues("Введите количество строк");
int n = EnteringValues("Введите количество столбцов");
int LeftBorder = EnteringValues("Введите минимальное значение для элементов массива");
int RightBorder = EnteringValues("Введите максимальное значение для элементов массива");

int[,] matrix = new int[m,n];

FillArray(matrix, LeftBorder, RightBorder, m, n);
PrintArray(matrix, m, n);
FindElement(matrix, m, n);
