// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

// Генерация

int[] RandArr()
{
    Console.Write("Enter array length: ");
    int len = int.Parse(Console.ReadLine()!);
    Console.Write("Enter minimal range value: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("Enter maximum range value: ");
    int max = int.Parse(Console.ReadLine()!);
    
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

void numCheck(int[] arr)
{
    Console.WriteLine("enter a number: ");
    int num = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            Console.WriteLine("This number is present in the array");
            break;
        }
        else if (i == arr.Length - 1 && arr[i] != num )
        {
            Console.WriteLine("There is no such number in the array");
        }          
    }  
}

int[] array = RandArr();
PrintArr(array);
numCheck(array);