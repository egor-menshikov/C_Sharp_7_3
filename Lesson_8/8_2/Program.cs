// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных. Значения элементов массива 0..9

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

// Считаем
int[] ElementFreq(int[,] arr, int numMax)
{
    int[] result = new int[numMax + 1];
    foreach (int item in arr)
    {
        result[item]++;
    }
    return result;
}

// Выводим что посчитали
void PrintArr(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Число {i} встречается {arr[i]} раз ");
        
    }
    Console.WriteLine();
    Console.WriteLine();
}

int[,] array = RandArr2D();
PrintArr2D(array);
Console.WriteLine();

int[] answer = ElementFreq(array, 10);
PrintArr(answer);