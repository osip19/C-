// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4->да
// - 3->нет
// 7->нет

System.Console.WriteLine("Введите число:");
int A = Convert.ToInt32(System.Console.ReadLine());
if (
	A % 2 == 0
) System.Console.WriteLine("Да");
else {
	System.Console.WriteLine("Нет");
};