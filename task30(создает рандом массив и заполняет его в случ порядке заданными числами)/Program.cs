// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

System.Console.Write("Введи число элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

// Решение через метод
int[] GetCount(int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
   return arr;
}


// Без метода
// int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }

System.Console.Write("[");
    foreach (var item in GetCount(num))
{
    System.Console.Write($"{item}, ");
}
System.Console.Write("\b\b] ");