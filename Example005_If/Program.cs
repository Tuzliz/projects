Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "илюша")
{
     Console.WriteLine("Ура, это же Илюша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}

