/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет   */

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 6.");

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
OurPower(number);


void OurPower(int number)
{   
    if(number%2 == 0)
    {
        Console.WriteLine($"{number} число чётное ");
    }
    else
    {
        Console.WriteLine($"{number} число нечётное ");
    }
}



