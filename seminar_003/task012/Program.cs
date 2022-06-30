/* Задача 18: Напишите программу, 
которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).   */ 

void Zadach18()
{
    Console.WriteLine("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
            // infiniti
    if ( n == 1) Console.WriteLine("0 < х < infiniti && 0 < y < infiniti");
    else if (n == 2) Console.WriteLine("-infiniti < х < 0 && 0 < y < infiniti");
    else if (n == 3) Console.WriteLine("-infiniti < х < 0 && -infiniti < y < 0");
    else if (n == 4) Console.WriteLine("0 < х < infiniti && -infiniti < y < 0");
    else Console.WriteLine("Введите значение от 1 до 4");
}

Zadach18();