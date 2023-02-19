// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6


// System.Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(System.Console.ReadLine());
// if (a <= 99)
// 	System.Console.WriteLine("В указанном числе нет третьей цифры");

// else if (a > 1000) a = a / 10;
// else if (a <= 999 && a >= 100)
// { System.Console.WriteLine(a % 10); }

int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n) - 2;
Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
// Console.ReadLine();