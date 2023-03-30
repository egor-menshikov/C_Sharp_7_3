// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

// Генерируем 2d массив 3x4 от 0 до 100
int[,] RandArr2D()
{
    Console.WriteLine();
    Console.WriteLine("Generating a 2d [3, 4] array..");

    int[,] arr = new int[3, 4];
    Random rand = new Random();

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            arr[i, j] = rand.Next(0, 101);
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

// Ищем элемент
void FindElement(int[,] arr)
{
    Console.WriteLine("Specify the address of the element to find..");
    Console.Write("Line: ");
    int line = int.Parse(Console.ReadLine()!);
    Console.Write("Column: ");
    int col = int.Parse(Console.ReadLine()!);

    if (line >= 1 && line <= arr.GetLength(0) && col >= 1 && col <= arr.GetLength(1))
        Console.WriteLine($"Answer: {arr[line - 1, col - 1]}");
    else 
        Console.WriteLine("The array does not have such address");
}

int[,] array = RandArr2D();
PrintArr2D(array);
FindElement(array);