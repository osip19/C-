Console.WriteLine("Введите число: ");
string? dayString = Console.ReadLine();
int numberDay = Convert.ToInt32(dayString);
if (numberDay > 7) Console.WriteLine("нет такого дня недели");
string[] days  =   new string [] {"Понедельник" , "Вторник",  "Среда" , "Четверг" , "Пятница" , "Суббота" , "Воскресенье"};
Console.WriteLine (days[numberDay - 1]) ;