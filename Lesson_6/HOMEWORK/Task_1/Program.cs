



// Генерируем 2d массив
int[,] RandArr2D()
{
    Console.WriteLine(String.Empty);
    Console.WriteLine("Generating a 2d array..");
    Console.Write("Enter array rows number: ");
    int row = int.Parse(Console.ReadLine()!);
    Console.Write("Enter array columns number: ");
    int col = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);

    int[,] arr = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < row; i++)
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
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write($"{arr[row, col]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Копируем поэлементно в новый массив
int[,] CopyArr2D(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    
    Console.WriteLine("blank 'result' array:");                 // Вывод массива, в который будем
    PrintArr2D(result);                                         // копировать, для наглядности.
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i, j] = arr[i, j];
        }
    }
    return result;
}

int[,] source = RandArr2D();
Console.WriteLine();
Console.WriteLine("initial 'source' array:");
PrintArr2D(source);

int[,] copy = CopyArr2D(source);
Console.WriteLine("new 'copy' array:");
PrintArr2D(copy);




