// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

int PosCount()
{
    int count = 0;
    string input = " ";
    int num;
    while (input != "")
    {
        Console.WriteLine("Enter a number, or press ENTER to stop adding numbers:");
        input = Console.ReadLine()!;
        if (input == "") break;
        num = int.Parse(input);
        if (num > 0) count++;            
    }
    return count;    
}

int answer = PosCount();
Console.WriteLine($"You entered {answer} positive numbers.");