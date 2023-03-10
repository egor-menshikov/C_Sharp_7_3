// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);

void divide(int nm1, int nm2)
{
    if (nm1 % nm2 == 0)
    {
        Console.WriteLine($"Число {nm2} кратно {nm1}");
    }
    else
    {
        Console.WriteLine($"Число {nm2} не кратно {nm1}");
        Console.WriteLine(nm1 % nm2);
    }
} 
divide(num1, num2);
