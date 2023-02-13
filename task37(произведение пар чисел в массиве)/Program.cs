// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

System.Console.Write("Введи количество элементов массива: ");
int Count_Numbers = Convert.ToInt32(Console.ReadLine());

int[] SumExremes(int num)
{
    int[] arr = CreateArr(num);
    arr = FillRandom(arr);
    
    int HalfLength = (arr.Length % 2 == 0) ? 
            HalfLength = arr.Length / 2 : 
            HalfLength = (arr.Length / 2) + 1;


    int[] ResultArr = new int[HalfLength];
    for (int i = 0, j = arr.Length - 1; i < HalfLength; i++, j--)
    {
        ResultArr[i] = arr[i] * arr[j];
        if (arr.Length % 2 == 1 && i == (HalfLength - 1))
        {
            ResultArr[i] = arr[i];
        }
    }
    return ResultArr;
}


int[] CreateArr(int numbers)
{
    int[] arr = new int[numbers];
    return arr;
}


int[] FillRandom(int[] arry)
{
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(1, 5);
    }
    Console.WriteLine(string.Join(", ", arry));
    return arry;
}

Console.WriteLine(string.Join(", ", SumExremes(Count_Numbers)));
