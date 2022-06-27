/* Задача 1. 
Пользователь вводит число N (N > 0). 
Программа должна вывести N единиц на экран.

N = 4 -> 1, 1, 1, 1
N = 2 -> 1, 1    */

/*Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 1 доп."); */

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

OneWarrior(N);

void OneWarrior( int N)
{
int count = 0;
if (N > 0)
{
    while (count < N)
    {
    Console.Write("1 ");    
    count++;
    }
}
}


