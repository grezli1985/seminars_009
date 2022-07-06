/* Задача 27: Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void Zadacha27()
{
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел: " + " " + SumDigits(number));
}
//452 -> 11

int SumDigits(int number)
{  
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = number / 10000 + (number / 1000) % 10 + ((number / 100) % 10) + ((number % 100) / 10) + (number % 10);
    }
    return sum;
}


Zadacha27();