// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 2D пространстве.

Console.WriteLine("Введите x1:");
int xnum1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1:");
int ynum1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите x2:");
int xnum2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2:");
int ynum2 = int.Parse(Console.ReadLine()!);

double distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

Console.WriteLine($"Расстояние между точками равно {distance(xnum1, ynum1, xnum2, ynum2)}");