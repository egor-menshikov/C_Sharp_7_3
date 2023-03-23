// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Генерация
int[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);
    
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

// Вывод
void PrintArr(int[] arr)
{
    Console.WriteLine(String.Empty);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");    
    }
    Console.WriteLine(String.Empty);
    Console.WriteLine(String.Empty);
}

// Считаем сумму нечетных
int oddSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
       result += arr[i];
    }
    return result;
}

// Вызов методов
int[] array = RandArr();
PrintArr(array);
Console.WriteLine($"Сумма нечетных позиций равна {oddSum(array)}");