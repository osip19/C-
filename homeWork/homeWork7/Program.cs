// Задача 14: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
if (
	a % 7 == 0 && a % 23 == 0
)
	System.Console.WriteLine("Кратно обоим числам");
else
{
	System.Console.WriteLine("Нет");
}