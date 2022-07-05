/*Задача 28: Напишите программу, 
которая принимает на вход число N и 
выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/ 

void Zadacha28()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Произведение чисел от 1 до {number} равна {FindFact(number)}");
}

int FindFact(int number)
{
    int fact = 1;
    for(int i = 1; i <= number; i++)
    {
        fact = fact*i;
    }
    return fact;
}


Zadacha28();
