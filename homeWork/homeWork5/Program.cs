// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int x = Random.Shared.Next(100, 1000);
System.Console.WriteLine(x);
int a = x / 100;
int b = x % 10;
System.Console.WriteLine($"{a}, {b}");
System.Console.WriteLine(a * 10 + b);