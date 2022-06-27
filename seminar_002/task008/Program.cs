/*12. Напишите программу, 
которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.*/

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Zadacha9(numberA, numberB);

void Zadacha9(int arg1, int arg2)
{
    if (arg1%arg2 == 0)
    {
        Console.WriteLine("является");
    }
    else
    {
        Console.WriteLine("не является");
    }
}
    
