// 3. Задайте одномерный массив из 10 случайных чисел.
//    Найдите количество элементов массива, значения 
// которых лежат в отрезке [10,99].

int[] RandArr()
{
    int len = 10;
    int min = 1;
    int max = 150;
    
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
}

int numInRange(int[] arr)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
            result++;
    }
    return result;
}

int[] array = RandArr();
PrintArr(array);
int answer = numInRange(array);
Console.WriteLine($"This array has {answer} elements in range 10-99");