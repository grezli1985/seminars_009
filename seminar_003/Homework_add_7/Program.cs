/*Задача 2. Дано трёхзначное число N.
Определить кратна ли трём сумма всех его цифр.
*/ 


Console.WriteLine("Введите  трехзначное число");
string number = (Console.ReadLine());

Zadacha14(number);

void Zadacha14(string currentNumber)
{
    if (currentNumber % number[0]==0 && currentNumber%number[1]==0 && currentNumber%number[2]==0)
    {
        Console.WriteLine($"{currentNumber} является кратным одновременно 7, и 23");
    }
    else
    {
        Console.WriteLine($"{currentNumber} не является одновременно кратным 7, и 23");
    }
}