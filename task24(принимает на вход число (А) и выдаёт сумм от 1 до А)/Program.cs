// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int n = 0;

// for (int i = 1; i <= num; i++)
// {
//     n = n + i;
// }



int GetSumm(int InputNum)
{
    int n = 0;

    for (int i = 1; i <= InputNum; i++)
    {
        n = n + i;
    }
    return n;
}

Console.WriteLine($"{num} -> {GetSumm(num)}");