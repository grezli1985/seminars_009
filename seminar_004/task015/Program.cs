/* Задача 24: Напишите программу,
которая принимает на вход число (А) и
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

void Zadacha24()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел от 1 до {number} равна {FindSum(number)}");
}

int FindSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

Zadacha24();
