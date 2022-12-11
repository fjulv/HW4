// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Реализовать через функции.

int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int Exp(int number, int power)
{
    int res = 1;
    for (int i = 1; i <= power; i++)
    {
        res = res * number;
    }
    return res;
}

int num1=Prompt("Введи число");
int num2=Prompt("Введи степень, в которую будем возводить число " + num1);
int exp=Exp(num1, num2);
System.Console.WriteLine("Полученный результат " + exp);