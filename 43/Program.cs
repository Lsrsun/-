// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = a * x + c, y = b * x + d; значения c, a, d и b задаются пользователем.

// c = 2, a = 5, d = 4, b = 9 -> (-0,5; -0,5)

double Input(string msg)
{
    Console.WriteLine(msg);
    double N = Convert.ToDouble(Console.ReadLine());
    return N;
}

void Point(double a, double b, double c, double d)
{
    double X = (d-c)/(a-b);
    double Y = (a * ((d-c)/(a-b)))+c;
    Console.WriteLine($"Точка пересечения: ({X}, {Y})");
}

double a = Input("Введите a");
double b = Input("Введите b");
double c = Input("Введите c");
double d = Input("Введите d");
Point(a, b, c, d);

