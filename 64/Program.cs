// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int Print(int m, int n){
//     if (m == n){
//         return n;
//     }
//     return Print(m+1, n) + m;
// }
// Console.WriteLine(Print(m,n));


int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int n) 
{
    if (n == 1) {
        Console.Write("1");
    } else {
        Console.Write(n + ", ");
        PrintNumbers(n - 1);
    }
}
PrintNumbers(n);