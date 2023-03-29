// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// Генерация 2d массива double
double[,] RandArr2D()
{
    Console.WriteLine();
    Console.WriteLine("Generating a 2d array..");
    Console.Write("Enter array rows number: ");
    int line = int.Parse(Console.ReadLine()!);
    Console.Write("Enter array columns number: ");
    int col = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value(double): ");
    double min = double.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value(double): ");
    double max = double.Parse(Console.ReadLine()!);

    double[,] arr = new double[line, col];
    Random rand = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = rand.NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

// Вывод 2d массива
void PrintArr2D(double[,] arr)
{    
    for (int line = 0; line < arr.GetLength(0); line++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write($" {Math.Round(arr[line, col], 2)} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Работа
double[,] array = RandArr2D();
Console.WriteLine();
PrintArr2D(array);