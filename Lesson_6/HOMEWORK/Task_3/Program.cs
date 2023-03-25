// Задача 2: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void LineCross()
{
    Console.Write("Enter b1: ");
    double b1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter k1: ");
    double k1 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter b2: ");
    double b2 = double.Parse(Console.ReadLine()!);
    Console.Write("Enter k2: ");
    double k2 = double.Parse(Console.ReadLine()!);
    
    if (k1 == k2 && b1 == b2) Console.WriteLine("These lines intersect in infinite points.");
    else if (k1 == k2 && b1 != b2) Console.WriteLine("These lines are parallel.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        if (x == -0) x = 0;  // Костыли. При параметрах 3 6 3 9
        if (y == -0) y = 0;  // выдает (-0; 3).
        Console.WriteLine($"These lines intersect in ({Math.Round(x, 5)}; {Math.Round(y, 5)}).");
    }
}
LineCross();