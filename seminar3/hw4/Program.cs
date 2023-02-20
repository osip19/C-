﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

// AB = КОРЕНЬ{ (xb - xa) ^ 2 + (yb - ya) ^ 2 + (zb - za) ^ 2}

System.Console.WriteLine("Введите координату первой точки по Х");
double x1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координату первой точки по Y");
double y1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координату первой точки по Z");
double z1 = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("Введите координату второй точки по X");
double x2 = Convert.ToDouble(System.Console.ReadLine()); 
System.Console.WriteLine("Введите координату второй точки по Y");
double y2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координату второй точки по Z");
double z2 = Convert.ToDouble(System.Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
System.Console.WriteLine("Расстояние мкжду точками = " + c);