// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int Print(int m, int n){
    if (m == 0) {
        return n+1;
    }
    if (n == 0 && m != 0) {
        return Print(m-1, 1);
    }
    //if (m > 0 && n > 0){
    else { 
        return Print(m-1, Print(m, n-1));
    }
}
Console.WriteLine(Print(m,n));
