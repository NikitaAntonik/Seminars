// Задача 67: Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int GetSum(int num)
{

    if (num == 0) return 0;
    else return num % 10 + GetSum(num / 10);
}


int n = Prompt("введи N: ");

System.Console.WriteLine(GetSum(n));