Console.WriteLine("Введите имя пользователя: ");
var username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}