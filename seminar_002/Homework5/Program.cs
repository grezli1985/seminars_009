/* Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6  */


Console.WriteLine("Введите число");
string number = Console.ReadLine();

TripleNamber(number);

void TripleNamber(string number)
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



