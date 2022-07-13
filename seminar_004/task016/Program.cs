/* Задача 26: Напишите программу, 
которая принимает на вход число и 
выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5*/ 


void Zadacha26()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"цифр в числе: " + " " + DigitsNumber(number));
}

int DigitsNumber(int number)
{  
        int i = 0;
        while (number > 0)
        {
            number = number / 10;
            i++;
        }
        return i;
}

Zadacha26();