// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int[] numbers = new int[10];
int[] numbers = {6, 7, 19, 345, 3};


// Console.WriteLine(string.Join(" ", numbers));
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = new Random().Next(-9, 10);
// }
Console.WriteLine(string.Join(", ", numbers));

int find = 4;
String Ans = "Нет";
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == find)
    {
        Ans = "Да"; 
        break;
    }
}
System.Console.WriteLine(Ans);