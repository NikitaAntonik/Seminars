Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 / number2;

if (result == number2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");  
}