Console.Write("Введите пароль: ");
string password = Console.ReadLine();

Console.Write("Подтвердите пароль: ");
string confirm = Console.ReadLine();

if (password == confirm)
{
    Console.WriteLine("Пароль принят");
}
else
{
    Console.WriteLine("Пароль не принят");
}