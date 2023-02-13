// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] numbers = new int[123];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0, 150);
}
Console.WriteLine(string.Join(", ", numbers));
int Count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] >= 10 && numbers[i] <= 99) Count += 1;
}
System.Console.WriteLine(Count);