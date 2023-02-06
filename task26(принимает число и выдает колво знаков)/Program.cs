// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// while (num >= 10)
// {
//     num = num / 10; // num/= 10;
//     i++;
// }
// System.Console.WriteLine(i);

int GetCountNumber(int InputNum)
{
    int i = 1;
    while (InputNum >= 10)
    {
        InputNum = InputNum / 10; // num/= 10;
        i++;
    }
    return i;
}

System.Console.WriteLine($"{num} -> {GetCountNumber(num)} ");