/* Задача 8: Напишите программу,
 которая на вход принимает число (N), 
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8   */

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 8.");

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
OurPower(number);

void OurPower( int N)
{
int count = 1;
    while (count <= N)
    {
        if(count%2 == 0)
        { 
            Console.Write(count + " ");
        }   
    count++;
    }
}







