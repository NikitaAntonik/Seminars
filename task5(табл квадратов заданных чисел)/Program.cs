// 2) Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Создаем переменную n
System.Console.Write("Введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());

// Создаем фкнкцию для заполнения массива
int[] MySqare(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++) // цикл для перебора значений
    {
        numbers[i] = (i + 1) * (i + 1); // начинаем перебор с (0 + 1) * (0 + 1) чтобы выводилось последнее зачение
    }
    return numbers;
}

// Функция для вовода элементов массива
void PrintArr(int[] coll)
{
    foreach (var item in coll)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine("\b\b");
}

// Создаем массив из 0 длинны n
int[] arr = new int[n];

// С помощью фкнуции PrintArr выводим получившийся пустой массив
PrintArr(arr);

// С помощью фкнуции MySqare перезаписываем пустой массив значениями квадратов
arr = MySqare(arr);

// С помощью фкнуции PrintArr выводим массив квадратов
PrintArr(arr);

// простой вариант решения через цикл for
// for (int i = 1; i <= n; i++)
// {
//     System.Console.WriteLine(i*i);
// }
