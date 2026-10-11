Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

Console.Write("Введите операцию (+, -, *, /): ");
string op = Console.ReadLine();

switch (op)
{
    case "+":
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;
    case "-":
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case "/":
        if (b == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль!");
        }
        else
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
        break;
    default:
        Console.WriteLine("Неизвестная операция");
        break;
}