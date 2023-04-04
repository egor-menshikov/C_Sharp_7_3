// Задача 54: Задайте двумерный массив. Напишите
// программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

// Генерируем 2d массив
int[,] RandArr2D()
{
    Console.WriteLine();
    Console.WriteLine("Generating a 2d array..");
    Console.Write("Enter array rows number: ");
    int line = int.Parse(Console.ReadLine()!);
    Console.Write("Enter array columns number: ");
    int col = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);

    int[,] arr = new int[line, col];
    Random rand = new Random();

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = rand.Next(min, max + 1);
        }
    }
    return arr;
}

// Вывод 2d массива
void PrintArr2D(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Сортировка
void SortArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - j - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
                }
            }
        }
    }
}

// Выполняем
int[,] array = RandArr2D();
Console.WriteLine();
PrintArr2D(array);
SortArr(array);
PrintArr2D(array);