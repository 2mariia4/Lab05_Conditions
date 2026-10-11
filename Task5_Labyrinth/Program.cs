Console.WriteLine("=== ТЁМНЫЙ ЛАБИРИНТ ===");
Console.WriteLine("Вы стоите перед первой дверью.");
Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
Console.WriteLine("Путь В: Пойти по тёмному коридору.");
Console.Write("Ваш выбор (A/B): ");

string path = Console.ReadLine().ToUpper();

if (path == "A")
{
    Console.WriteLine("\nДракон говорит: \"Кто не дышит, но живёт;");
    Console.WriteLine("хоть не нужно — много пьёт;");
    Console.WriteLine("и в жизни, и в смерти тело как лёд.\"");
    Console.Write("Ваш ответ: ");

    string answer = Console.ReadLine().ToLower();

    if (answer == "рыба")
    {
        Console.WriteLine("Дракон открывает дверь. Вы прошли дальше!");
    }
    else
    {
        Console.WriteLine("Дракон съел вас! Игра окончена.");
    }
}
else if (path == "B")
{
    Console.WriteLine("\nВы в тёмной комнате с двумя дверями.");
    Console.WriteLine("Дверь 1: За ней сокровища Dungeon Master'а.");
    Console.WriteLine("Дверь 2: За ней ловушка с ядовитыми шипами.");
    Console.Write("Ваш выбор (1/2): ");

    string door = Console.ReadLine();

    switch (door)
    {
        case "1":
            Console.WriteLine("Вы нашли сокровища Dungeon Master'а! Победа!");
            break;
        case "2":
            Console.WriteLine("Ловушка! Ядовитые шипы. Вы погибли.");
            break;
        default:
            Console.WriteLine("Вы стоите в нерешительности и теряете время...");
            break;
    }
}
else
{
    Console.WriteLine("Вы не выбрали путь. Игра окончена.");
}