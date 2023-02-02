//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 & y > 0)
{
    Console.WriteLine("четверть 1");
}
else if (x < 0 & y > 0)
{
    Console.WriteLine("четверть 2");
}
else if (x < 0 & y < 0)
{
    Console.WriteLine("четверть 3");
}
else if (x > 0 & y < 0)
{
    Console.WriteLine("четверть 4");
}


