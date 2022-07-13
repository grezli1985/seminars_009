/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */
/*
void Zadach19()
{
    Console.WriteLine("Введите пятизначное число: ");
    string c = (Console.ReadLine());

    if (c[0] == c[4] || c[1] == c[3])
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом!");
    }

}

Zadach19();     */

// "15751"
//          0   1   2   3   4
//number = '1' '5' '7' '5' '1'
//number[0] == number[4]
//number[1] == number[3]

void Zadacha19()
{
    int number = 18361;
    int digitOnes = number%10;           // 16361%10 = 1
    int digitTens = number/10%10;        // 16361/10 = 1636 % 10 = 6
    int digitThousand = number/1000%10;  // 16361/1000 = 16 % 10 = 6
    int digitTenOfThousands = number/10000;

    if(digitOnes == digitTenOfThousands && digitTens == digitThousand)
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом!");
    }

}

Zadacha19();