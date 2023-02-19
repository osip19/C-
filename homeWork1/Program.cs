// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите третье  число:");
int c = Convert.ToInt32(System.Console.ReadLine());

if (a > b)
{ System.Console.WriteLine(a); }
else if (b > c)
{ System.Console.WriteLine(b); }
else if (c > a)
{ System.Console.WriteLine(c); }
