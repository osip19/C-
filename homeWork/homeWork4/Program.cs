// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int x = Random.Shared.Next(10, 100);
System.Console.WriteLine(x);
int a = x % 10;
int b = x / 10;
if (
	a > b
)
{
	System.Console.WriteLine(a);
}
else { System.Console.WriteLine(b); }