// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            coll[i, j] = i + j;
        }
    }
    return coll;
}


int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
arr = FillArray(arr);
PrintArr(arr);