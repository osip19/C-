// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
// 645-> 5
// 78->третьей цифры нет
// 32679 -> 6


System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(System.Console.ReadLine());
if (a <= 99)
	System.Console.WriteLine("В указанном числе нет третьей цифры");
else (a <= 999)
{ System.Console.WriteLine(a % 10); }
// for (int i = 0; i >= 999; i++)
// 	else if (a / 10 >= 999) ;
// System.Console.WriteLine(a % 10);


// System.Console.WriteLine(a);