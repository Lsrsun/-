// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int Print(int m, int n){
    if (m == n){
        return n;
    }
    return Print(m+1, n) + m;
}
Console.WriteLine(Print(m,n));