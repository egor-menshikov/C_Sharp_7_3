// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Генерируем 2d массив
int[,] RandArr2D()
{
    Console.WriteLine();
    Console.WriteLine("Generating a 2d array..");
    Console.Write("Enter array rows number: ");
    int line = int.Parse(Console.ReadLine()!);
    Console.Write("Enter array columns number: ");
    int col = int.Parse(Console.ReadLine()!);
    // Console.Write("Enter minimal range value: ");
    // int min = int.Parse(Console.ReadLine()!);
    // Console.Write("Enter maximum range value: ");
    // int max = int.Parse(Console.ReadLine()!);
    int min = 1;
    int max = 5;

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
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Находим произведение
int[,] ProductArr(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        Console.WriteLine("Эти матрицы нельзя перемножить.");
        return result;
    }
    else
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    result[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        return result;
    }
}

// Тут проверял пример из условий
// int[,] array1 = { { 2, 4 }, { 3, 2 } };
// PrintArr2D(array1);
// int[,] array2 = { { 3, 4 }, { 3, 3 } };
// PrintArr2D(array2);
// int[,] answer = ProductArr(array1, array2);
// PrintArr2D(answer);

// Сгенерируем два массива и попробуем перемножить
// Вводим только размеры, значения будут от 1 до 5.
Console.WriteLine("Введите параметры первого массива:");
int[,] array1 = RandArr2D();
Console.WriteLine("Введите параметры второго массива:");
int[,] array2 = RandArr2D();

Console.WriteLine();
Console.WriteLine("Массивы 1 и 2:");
Console.WriteLine();
PrintArr2D(array1);
PrintArr2D(array2);

Console.WriteLine("Умножаем..");
int[,] answer = ProductArr(array1, array2);
PrintArr2D(answer);