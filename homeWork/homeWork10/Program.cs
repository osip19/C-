// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6

// 																					РЕШЕНИЕ ИЗ ИНТЕРНЕТА
// int n = int.Parse(Console.ReadLine());
// int k = (int)Math.Log10(n) - 2;
// Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
// Console.ReadLine();
// 
// 																								И ЕЩЕ ОДНО
// int n = int.Parse(Console.ReadLine()!); ;
// 	int d = GetSecondDigit(n);
// 	Console.WriteLine(d);
// 	// Console.ReadKey();
// static int GetSecondDigit(int k)
// {
// 	while (k >= 1000) k /= 10;
// 	int d = k % 10;
// 	return d;
// }

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
if (a <= 99)
	System.Console.WriteLine("В указанном числе нет третьей цифры");

while (a >= 1000) a /= 10;
int b = a % 10;
if (b < 1000)
	System.Console.WriteLine(b);
else
{
	System.Console.WriteLine("Непредвиденная ошибка");
}