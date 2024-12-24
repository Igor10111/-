using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Чтение числа от пользователя
        Console.WriteLine("Введите трёхзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверка, что число трёхзначное
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка: введите трёхзначное число!");
            return;
        }
        // Извлечение цифр числа
        int hundreds = number / 100;     // Первая цифра (сотни)
        int tens = (number / 10) % 10;   // Вторая цифра (десятки)
        int ones = number % 10;          // Третья цифра (единицы)

        // Вычисление суммы и произведения цифр
        int sum = hundreds + tens + ones;
        int product = hundreds * tens * ones;

        // Вывод результатов
        Console.WriteLine($"Сумма цифр: " + sum);
        Console.WriteLine($"Произведение цифр: " + product);
    }
}
