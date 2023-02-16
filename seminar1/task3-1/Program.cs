Console.WriteLine("Введите число: ");
string? dayString = Console.ReadLine();
int numberDay = Convert.ToInt32(dayString);
if (numberDay < 7)
{
	string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
	Console.WriteLine(days[numberDay - 1]);
}
else
{
	Console.WriteLine("нет такого дня недели");
}