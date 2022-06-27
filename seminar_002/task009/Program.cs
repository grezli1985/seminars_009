/*14. Напишите программу,
 которая принимает на вход число и проверяет,
  кратно ли оно одновременно 7 и 23.*/

Console.WriteLine("Введите  число");
int number = Convert.ToInt32(Console.ReadLine());
Zadacha(number);

void Zadacha(int currentNumber)
{
    if (number%7==0 & number%23==0)
    {
        Console.WriteLine($"{number} является кратным одновременно 7, и 23");
    }
    else
    {
        Console.WriteLine($"{number} не является одновременно кратным 7, и 23");
    }
}