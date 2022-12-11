// Задача 3: Напишите программу, 
// которая выводит массив из 8 элементов, 
// заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции 
// (пригодится в следующих задачах). 
// Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)

int Prompt(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateAray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
}

int length=Prompt("Введи длину массива");
int min=Prompt("Введи минимальное значение для массива");
int max=Prompt("Введи максимальное значение для массива");

int[] array = GenerateAray(length,min,max);
PrintArray(array);
