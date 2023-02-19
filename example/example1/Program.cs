System.Console.Write("Введите Ваше имя: ");
string? userName = System.Console.ReadLine();
System.Console.WriteLine("Привет, " + userName);

System.Console.WriteLine("Начало следующего приветствия");

System.Console.Write("Введите Ваше имя: ");
string? user1Name = System.Console.ReadLine();
if (user1Name?.ToLower() == "маша")
{
	System.Console.Write("Ура, это же Маша!");
}
else {
	System.Console.WriteLine("Привет, " + user1Name);
}

