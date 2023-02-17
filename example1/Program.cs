// System.Console.Write("Введите Ваше имя: ");
// string? userName = System.Console.ReadLine();
// System.Console.Write("Привет, " + userName);

System.Console.Write("Введите Ваше имя: ");
string? userName = System.Console.ReadLine();
if (userName?.ToLower() == "маша")
{
	System.Console.Write("Ура, это же Маша!");
}
else {
	System.Console.WriteLine("Привет, " + userName);
}

