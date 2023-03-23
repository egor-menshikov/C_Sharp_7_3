// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Генерация массива указанной длины в диапазоне
// положительных трехзначных.
int[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

// Вывод
void PrintArr(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
}

// Подсчет четных
int evenCount(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = RandArr();
PrintArr(array);
Console.WriteLine();
Console.WriteLine($"В этом массиве {evenCount(array)} четных чисел");