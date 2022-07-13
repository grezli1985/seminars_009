/* Задача 7: 
Напишите программу, 
которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 
4 -> "-4,-3,-2,-1,0,1,2,3,4" 
2 -> "-2,-1,0,1,2" */

Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 5.");

int number = -4;// -4 -3 -2 -1 0 1  2 3 4
number = Math.Abs(number);
int count = -number;
while (count <= number)
{
    Console.Write(count + "  ");
    count++;
}
Console.WriteLine();


