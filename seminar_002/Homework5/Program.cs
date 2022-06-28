/* Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6  */


Random rand = new Random();
int number = rand.Next(10, 1000);
Zadacha11(number);

void Zadacha11(int currentNamber)
{
    Console.WriteLine(currentNamber);
    // 961 -> 961/100 = 9 , 961 % 100 / 10 = 6   
    int A = currentNamber / 100;
    int B = currentNamber % 10;
    int result = A * 10 + B;
    Console.WriteLine(result);
}