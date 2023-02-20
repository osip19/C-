// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// 1-> “x > 0 && y > 0” 
// 2-> “x < 0 && y > 0” 
// 3-> “x < 0 && y < 0” 
// 4-> “x > 0 && y < 0”
// 5-> “Неверно введен номер четверти” 


System.Console.WriteLine("Введите координату по Х:");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите координату по У:");
int y = Convert.ToInt32(System.Console.ReadLine());

if (x > 0 && y > 0) { System.Console.WriteLine("Координата находится в первой четверти."); }
else if (x < 0 && y > 0) { System.Console.WriteLine("Координата находится во второй четверти."); }
else if (x < 0 && y < 0) { System.Console.WriteLine("Координата находится в третьей четверти."); }
else if (x > 0 && y < 0) { System.Console.WriteLine("Координата находится в четвертой четверти."); }
else
{
	System.Console.WriteLine("Невозможно определить четверть");
}