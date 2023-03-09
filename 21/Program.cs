// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Coordinate(string C, string Name)
{
    Console.Write($"Введите координату {C} точки {Name}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double PowerX = Math.Pow((x2-x1), 2);
double PowerY = Math.Pow((y2-y1), 2);
double PowerZ = Math.Pow((z2-z1), 2);
double D = Math.Sqrt(PowerX + PowerY + PowerZ);
Console.WriteLine($"Расстояние между точками: {D}");