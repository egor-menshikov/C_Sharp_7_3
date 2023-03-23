// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

// Генерация double
double[] RandArr()
{
    Console.WriteLine("Generating an array of float numbers:");
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    double min = double.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    double max = double.Parse(Console.ReadLine()!);
    
    double[] arr = new double[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().NextDouble() * (max - min) + min;
    }
    return arr;
}

// Вывод double
void PrintArr(double[] arr)
{
    Console.WriteLine(String.Empty);
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine(String.Empty);
    Console.WriteLine(String.Empty);
}

// Считаем разность максимального и минимального элементов
double minmaxDiff(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
        if (max < arr[i]) max = arr[i];
    }
    double result = max - min;
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max = {max}");
    return result;
}

// Вызов методов
double[] array = RandArr();
PrintArr(array);
double answer = minmaxDiff(array);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {answer}");