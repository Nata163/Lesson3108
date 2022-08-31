Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower( ) == "наталья")
{
     Console.WriteLine("Ура, это Наташа");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}    