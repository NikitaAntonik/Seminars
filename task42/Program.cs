// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(x,2);
Console.WriteLine(b);
