Console.Write("Введите номер четверти: ");
int xy = Convert.ToInt32(Console.ReadLine());
if (xy == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else if (xy == 2)
{
        Console.WriteLine("x < 0 и y > 0");
    }
    else if (xy == 3)
    {
        Console.WriteLine("x < 0 и y < 0");
    }
    else if (xy == 4)
    {
        Console.WriteLine("x > 0 и y < 0"); 
    }
    else{
        Console.WriteLine("Такой четверти не существует.");
    }
