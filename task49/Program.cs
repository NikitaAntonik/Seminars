// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
            System.Console.Write($"{array[i, j], 4}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArrayRandom(int[,] coll)
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


int[,] FillArray(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i+= 2)
    {
        for (int j = 0; j < coll.GetLength(1); j += 2)
        {
            coll[i, j] *= coll[i, j];
        }
    }
    return coll;
}


int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
arr = FillArrayRandom(arr);
PrintArr(arr);
arr = FillArray(arr);
System.Console.WriteLine();
PrintArr(arr);