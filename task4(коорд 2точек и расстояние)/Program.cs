// 21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//  в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

System.Console.Write("Введи координаты Ax: ");
double Ax = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи координаты Ay: ");
double Ay = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи координаты Bx: ");
double Bx = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введи координаты By: ");
double By = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2)), 3);
System.Console.WriteLine(distance);
