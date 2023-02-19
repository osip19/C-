// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7, min = 5
// a = 2 b = 10->max = 10, min = 2
// a = -9 b = -3->max = -3, min = -9

System.Console.WriteLine("Введите первое число:");
int A = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int B = Convert.ToInt32(System.Console.ReadLine());
if (
	A > B) System.Console.WriteLine("Большее число " + A);

else
{
	System.Console.WriteLine("Большее число " + B);
};

