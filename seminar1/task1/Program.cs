Console.WriteLine("Введите число А: ");
string? answerA = Console.ReadLine();
int A = Convert.ToInt32(answerA);

Console.WriteLine("Введите число B: ");
string? answerB = Console.ReadLine();
int B = Convert.ToInt32(answerB);

if (A== B*B)
Console.WriteLine("Да");
else Console.WriteLine("Нет");