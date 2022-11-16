// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


void CreateArrayRndInt (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int IsPositive(int[] num, int size)
{
int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (num[i] > 0)
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine("Введите желаемое количество числел: ");
int usSize = Convert.ToInt32(Console.ReadLine());
    
int[] numbers = new int[usSize];
CreateArrayRndInt(numbers);
PrintArray(numbers);
Console.WriteLine();

Console.WriteLine($"Количество чисел больше нуля: {IsPositive(numbers, usSize)}");