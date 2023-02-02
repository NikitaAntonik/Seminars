//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

System.Console.Write("Введи число x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи числоy y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) System.Console.WriteLine("первая четверть");
else if (x < 0 && y > 0) System.Console.WriteLine("вторая четверть");
else if (x < 0 && y < 0) System.Console.WriteLine("третья четверть");
else if (x > 0 && y < 0) System.Console.WriteLine("четвертая четверть");
else System.Console.WriteLine("точка находится на одной или нескольких осях");
