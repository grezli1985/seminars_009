/*14. Напишите программу,
 которая принимает на вход число и проверяет,
  кратно ли оно одновременно 7 и 23.*/

Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha14(number);

void Zadacha14(int currentNumber)
{
    if (currentNumber%7==0 && currentNumber%23==0)
    {
        Console.WriteLine($"{currentNumber} является кратным одновременно 7, и 23");
    }
    else
    {
        Console.WriteLine($"{currentNumber} не является одновременно кратным 7, и 23");
    }
}


// & - коньюкция v и
// a & b
//a && b && c && d