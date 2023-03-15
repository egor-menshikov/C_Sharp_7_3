// Задача 23
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое число, не равное 0: ");
int number = int.Parse(Console.ReadLine()!);

void pow3(int num)
{ 
    if (num == 0)
    {
        Console.WriteLine("Вы ввели 0.");
        return;
    }
    if (num < 0) num *= -1;
    int i;
    for (i = 1; i <= num; i++) Console.Write($"{Math.Pow(i, 3)} ");   
}

pow3(number);