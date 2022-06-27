/* Задача 2.
 Даны два числа a, b, такие что a < b.
 Вывести на экран сколько раз число a поместиться в числе b. */

/*Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 2 доп."); */

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int result = 0;

Div(result);

void Div (int once)
{
if (a < b) ;
{
    int result = (b / a);
    Console.WriteLine($"{result} раз столько раз поместиться первое число во второе!");
}
}


