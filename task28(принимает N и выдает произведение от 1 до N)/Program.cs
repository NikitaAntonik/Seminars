// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

System.Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetFactorial(int number)
{
    int n = 1;

    for (int i = 1; i <= number; i++)
    {
        n = n * i;
    }
    return n;
}

System.Console.WriteLine($"{num} -> {GetFactorial(num)}");