// 21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//  в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты первой точки (xa ≠ 0 и ya ≠ 0): ");
int xa = Convert.ToInt32(Console.ReadLine());
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты второй точки (xb ≠ 0 и yb ≠ 0): ");
int xb = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());

//double dist = Math.Sqrt((xb-xa)^2 + (yb-ya)^2);
int x = xb - xa;
int y = yb -ya;
double length = Math.Pow(x,2);
double length1 = Math.Pow(y,2);
double dist = Math.Sqrt(length + length1);
Console.Write(dist);

