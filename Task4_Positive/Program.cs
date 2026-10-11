Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int sum = 0;

if (a > 0) sum += a;
if (b > 0) sum += b;
if (c > 0) sum += c;

Console.WriteLine($"Сумма положительных чисел: {sum}");