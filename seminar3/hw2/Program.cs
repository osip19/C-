// Задача №22.Работа в группах

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
int b = 0;
while (b <= a)
{
	double c = Math.Pow(b, 3);
	b++;
	System.Console.WriteLine(c);
}
