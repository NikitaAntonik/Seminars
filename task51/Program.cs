// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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
            System.Console.Write($"{array[i, j],4}  ");
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


int SumDiagonal(int[,] coll)
{
    int sum = 0;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            if (i == j) sum += coll[i, j];
        }
    }
    return sum;
}


int[,] arr = CreaateArray(Prompt("Введи кол-во строк: "), Prompt("Введи кол-во столбцов: "));
arr = FillArrayRandom(arr);
PrintArr(arr);
System.Console.WriteLine(SumDiagonal(arr));