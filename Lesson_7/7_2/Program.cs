// 2. Задайте двумерный массив. Найдите элементы,
// у которых обе позиции чётные, и замените эти 
// элементы на их квадраты.


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
    for (int line = 0; line < arr.GetLength(0); line++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            Console.Write($"{arr[line, col]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Работаем
void EvenSqr(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 1; j < arr.GetLength(1); j += 2)
        {
            arr[i, j] *= arr[i, j];
        }
    }
}

int[,] array = RandArr2D();
PrintArr2D(array);
EvenSqr(array);
PrintArr2D(array);