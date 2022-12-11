// Задача 2: Напишите программу,
// которая принимает на вход число
// и выдаёт сумму цифр в числе.
// Реализовать через функции.

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int number)
{
    int sum = 0;
    int value = 0;
    if (number < 0)
    {
        number = -number;
    }
    while (number > 0)
    {
        value = number % 10;
        sum = sum + value;
        number = number / 10;

    }
    return sum;
}

int num = Prompt("Введи число");
int sum = Sum(num);
System.Console.WriteLine($"Сумма цифр числа {num} равна {sum}");