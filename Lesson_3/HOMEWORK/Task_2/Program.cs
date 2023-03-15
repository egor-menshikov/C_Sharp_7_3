// Задача 21
// Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A:");
Console.Write(" x: ");
int xnum1 = int.Parse(Console.ReadLine()!);
Console.Write(" y: ");
int ynum1 = int.Parse(Console.ReadLine()!);
Console.Write(" z: ");
int znum1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B:");
Console.Write(" x: ");
int xnum2 = int.Parse(Console.ReadLine()!);
Console.Write(" y: ");
int ynum2 = int.Parse(Console.ReadLine()!);
Console.Write(" z: ");
int znum2 = int.Parse(Console.ReadLine()!);



double distance3d(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

Console.WriteLine($"Расстояние между точками равно {distance3d(xnum1, ynum1, znum1, xnum2, ynum2, znum2)}");

// void distance3d(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     Console.WriteLine($"Расстояние между точками равно {Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))}");
// }

// distance3d(xnum1, ynum1, znum1, xnum2, ynum2, znum2);