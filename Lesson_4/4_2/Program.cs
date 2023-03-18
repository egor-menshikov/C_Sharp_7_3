// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int productToNum(int num)
{
    int product = 1;
    for(int i = 1; i <= num; i++)
    {
        product *= i;
    }
    return product;
}

Console.WriteLine("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);
int result = productToNum(n);
Console.WriteLine(result);