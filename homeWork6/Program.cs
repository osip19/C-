// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(System.Console.ReadLine());
if (
	a % b == 0
)
{
	System.Console.WriteLine("Кратно");
}
else { System.Console.WriteLine("Не кратно, остаток " + (a / b)); }

