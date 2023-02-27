// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int GetNum (int min, int max)
{
    if (min == max) return max;
    else 
    {   
        Console.Write(min);
        return GetNum(min + 1, max);
    }
}


int n = Prompt("введи N: ");
int m = Prompt("введи M: ");
System.Console.WriteLine(GetNum(n, m));