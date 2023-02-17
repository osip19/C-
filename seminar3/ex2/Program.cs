﻿// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.



int ReadNumber(string messageToUser)
{
	Console.WriteLine(messageToUser);
	int value = int.Parse(Console.ReadLine()!);
	return value;
}

int x = ReadNumber("Введите координату точки по X");
int y = ReadNumber("Введите координату точки по Y");

// Console.WriteLine(
// 	x > 0 && y > 0 ? "Точка находится в первой координатной четверти" :
// 	x < 0 && y > 0 ? "Точка находится во второй координатной четверти" :
// 	x < 0 && y < 0 ? "Точка находится в третьей координатной четверти" :
// 	x > 0 && y < 0 ? "Точка находится в четвертой координатной четверти" :
// 	"Невозможно определить координатную четверть"
// );

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной четверти");
}
else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}
