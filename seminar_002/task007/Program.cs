/* Задача 11.
Напишите программу,
которая выводит случайное трёхзначное число
и удаляет вторую цифру этого числа.*/
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(10, 1000);
Console.WriteLine(number);

Zadacha11(number);

void Zadacha11(int currentNamber)
{
    // 961 -> 961/100 = 9 , 961 % 10  = 1   
    int A = currentNamber / 100;         // 768/100 = 7
    //int C = currentNamber %100 / 10;   // 768 % 100 = 68 / 10 = 6   Эта переменная не нужна
    int B = currentNamber % 10;          // 768 % 10 = 8
    int result = A * 10 + B;
    Console.WriteLine(result);
}

// Через массив

/* Console.WriteLine("Введите число");
string number = Console.ReadLine();

TripleNamber(number);

void TripleNamber(string number)
{
    Console.WriteLine(number);
    Console.Write(number[0]);
    Console.Write(number[2]);
    Console.WriteLine();
} */