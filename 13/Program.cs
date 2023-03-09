// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0) N = -N;
if (N < 100 && N > 0) 
{
    Console.WriteLine("Третьей цифры нет"); 
}
else 
{
    int D = N% 10;
    Console.WriteLine(D);
};