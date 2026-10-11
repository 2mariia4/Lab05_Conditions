// 1. Загадываем число
Random random = new Random();
int secret = random.Next(1, 101);

// 2. Счётчик попыток и флаг победы
int attempts = 0;
bool guessed = false;

// 3. Заголовок
Console.WriteLine("Угадай число (1-100)");
Console.WriteLine("Я загадал число. Попробуй угадать!");

// 4. Основной цикл игры
string result = attempts <= 7
    ? $"Отличный результат! Всего {attempts} попыток"
    : $"Число найдено за {attempts} попыток. Можно лучше!";

// 5. Безопасное преобразование строки в число
Console.WriteLine($"� Правильно! Загаданное число: {secret}");
Console.WriteLine($"{result}");

// 6. Проверка диапазона
string GetHint(int difference) {
    switch (difference) {
        case <= 3:
            return "� Горячо!";
        case <= 10:
            return "� Тепло.";
        case <= 25:
            return "� Прохладно.";
        default:
            return "❄ Холодно!";
    }
}

// 7. Засчитываем только корректные попытки
    while (!guessed) {
    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
    string input = Console.ReadLine();
    if (!int.TryParse(input, out int guess)) {
        Console.WriteLine("!!! Введи целое число, а не текст!");
        continue;
    }
    if (guess < 1 || guess > 100) {
        Console.WriteLine("!!! Число должно быть от 1 до 100!");
        continue;
    }
    attempts++;
    if (guess < secret) {
        int diff = secret - guess;
        string hint = GetHint(diff);
        Console.WriteLine($"↑ Больше! {hint}\n");
    }
    else if (guess > secret) {
        int diff = guess - secret;
        string hint = GetHint(diff);
        Console.WriteLine($"↓ Меньше! {hint}\n");
    }
    else {
        guessed = true;
    }
}