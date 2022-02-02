Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "вика")
{
    Console.WriteLine("Ура! это ВИКА!");
}
else 
{
    Console.Write("Добро пожаловать, ");
Console.WriteLine(username);
}