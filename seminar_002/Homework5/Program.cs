/* Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6  */

/*
Console.WriteLine("Введите число");
string number = Console.ReadLine();

TripleNamber(number);

void TripleNamber(string number)  // через строку
{  
    if (number.Length >= 3)
    {
        Console.WriteLine(number[2]);
    }
    else 
    {
        Console.WriteLine("третья цифра отсутствует");
    }
}
*/
void Zadacha13()  // математический
{
    int number = 2754854;  // 275 % 10 = 5;  2754885 -> 275
    int digit = 0;
    while(number/100 > 0)
    {
        digit = number % 10;
        number/=10;
    }
    Console.WriteLine(digit);
}

Zadacha13();