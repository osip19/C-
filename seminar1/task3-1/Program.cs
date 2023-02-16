Console.WriteLine("Введите число: ");
string? dayString = Console.ReadLine();
int numberDay = Convert.ToInt32(dayString);
string[] days  =   new string [] {"Понедельник" , "Вторник",  "Среда" , "Четверг" , "Пятница" , "Суббота" , "Воскресенье"};
Console.WriteLine (days[numberDay - 1]) ;
if (dayString )