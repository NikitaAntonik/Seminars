// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int GetDegree(int n, int m)
{
    if (m == 1) return n;
    else return n * GetDegree(n, m - 1);
}


int n = Prompt("введи основание: ");
int m = Prompt("введи показатель: ");

System.Console.WriteLine(GetDegree(n, m));