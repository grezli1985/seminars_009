/* Задача 
11. Напишите программу,
 которая выводит случайное трёхзначное число
  и удаляет вторую цифру этого числа.*/
// 456 -> 46
/*
Random rand = new Random();
int number = rand.Next(100, 1000);
Zadacha9(number);

void Zadacha9(int currentNumber)
{
    Console.WriteLine(currentNumber);
    //96 -> 96/10 = 9    96 % 6 = 6
    int digitFirst = currentNumber/100;
    int digisecond = currentNumber%10;
    int result = digitFirst*10 + digisecond;
    
    
    Console.WriteLine(result);
}
*/

Random rand = new Random();
int number = rand.Next(10, 1000);
Console.WriteLine(number);

Zadacha11(number);

void Zadacha11(int currentNamber)
{
    // 961 -> 961/100 = 9 , 961 % 10  = 1   
    int A = currentNamber / 100;
    int B = currentNamber % 10;
    int result = A * 10 + B;
    Console.WriteLine(result);
}