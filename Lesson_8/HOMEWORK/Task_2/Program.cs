// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

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

// Вывод массива 1d
void PrintArr(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
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

// Собираем суммы элементов каждой строки
int[] LineSum(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i] += arr[i,j];
        }
    }
    return result;
}

// Ищем строку с наименьшей суммой
void MinLine(int[] arr)
{
    int minElement = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            minElement = arr[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка {minIndex + 1} с суммой элементов {arr[minIndex]} - строка с наименьшей суммой.");
}

int[,] array = RandArr2D();
Console.WriteLine();
PrintArr2D(array);

int[] sumArr = LineSum(array);
Console.Write("Суммы элементов строк: ");
PrintArr(sumArr);
MinLine(sumArr);