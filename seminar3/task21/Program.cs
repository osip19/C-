// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21

// AB = корень ( ( xb - xa ) 2 + (yb - ya) 2 )

System.Console.WriteLine("Введите координату первой точки по Х");
double x1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координату первой точки по Y");
double y1 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координату второй точки по Х");
double x2 = Convert.ToDouble(System.Console.ReadLine());
System.Console.WriteLine("Введите координату второй точки по Y");
double y2 = Convert.ToDouble(System.Console.ReadLine());

double c = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
System.Console.WriteLine("Расстояние мкжду точками = " + c);