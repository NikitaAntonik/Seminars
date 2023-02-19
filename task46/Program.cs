// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int Prompt(string massege)
{
    System.Console.Write(massege);
    var readInput = Console.ReadLine();
    int result = Convert.ToInt32(readInput);
    return result;
}


int[,] CreaateArray(int m, int n)
{
    int[,] array = new int[m, n];
    return array;
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j], 4} ");
        }
        System.Console.WriteLine();
    }
}


int[,] FillArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            coll[i, j] = new Random().Next(-9, 10);
        }
    }
    return coll;
}


int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
arr = FillArray(arr);
PrintArr(arr);
