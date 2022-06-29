/*12. Напишите программу, 
которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.*/

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Zadacha12(numberA, numberB);

void Zadacha12(int arg1, int arg2)
{
    if (arg1%arg2 == 0)
    {
        Console.WriteLine($"{arg1} является кратным {arg2}");
    }
    else
    {
        Console.WriteLine($"{arg1} не является кратным {arg2}, остаток равен {arg1%arg2}");
    }
}
    
