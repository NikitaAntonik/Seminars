// Задача 63: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void GetNum (int num)
{
    if (num  == 0) return;
    else if (num < 0) 
    {
        Console.Write($"{num} не натуральное число");
        return; 
    }
    GetNum (num - 1);
    Console.Write("{0,3}", num);
}

int n = Prompt("введи N: ");
GetNum(n);