// 8) Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.Write("Введи номер четверти: ");
int quarterNumber = Convert.ToInt32(Console.ReadLine());

if (quarterNumber == 1) System.Console.WriteLine("x ∈ (0; + ∞)\ny ∈ (0; + ∞)");
else if (quarterNumber == 2) System.Console.WriteLine("x ∈ (0; - ∞)\ny ∈ (0; + ∞)");
else if (quarterNumber == 3) System.Console.WriteLine("x ∈ (0; - ∞)\ny ∈ (0; - ∞)");
else if (quarterNumber == 4) System.Console.WriteLine("x ∈ (0; + ∞)\ny ∈ (0; - ∞)");
else System.Console.WriteLine("введи число от 1 до 4");