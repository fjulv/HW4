// Задача *: Напишите программу, 
// которая из массива случайных чисел ищет второй максимум 
// (число меньше максимального элемента, но больше всех остальных). 
// Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5


int Prompt(string message)
{
    System.Console.WriteLine($"{message} ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray(int Length, int MinRange, int MaxRange)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(MinRange, MaxRange + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}


int maxValue(int[] array)
{
    int max1 = int.MinValue;
    int max2 = int.MinValue;

    if (array[1] > array[2])
    {
        max1 = array[1];
        max2 = array[2];
    }
    else
    {
        max2 = array[1];
        max1 = array[2];
    }
    for (int i = 2; i < array.Length; i++)
    {
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
        else if (array[i] > max2 && array[i] != max1)
        {
            max2 = array[i];
        }
    }
    return max2;
}

int leng = Prompt("Введи длину массива");
int minnum = Prompt("Введи минимальный элемент массива");
int maxnum = Prompt("Введи максимальный элемент массива");

int[] arr = GenerateArray(leng, minnum, maxnum);
PrintArray(arr);
System.Console.WriteLine("Второе максимальное число в массиве " + maxValue(arr));
