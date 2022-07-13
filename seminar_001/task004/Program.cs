/* Задача 5: Напишите программу, 
вычесления значения функции возведения числа в квадрат.
4 -> 16
-3 -> 9
-7 -> 49 */

//
Console.WriteLine();
Console.WriteLine("__________________");
Console.WriteLine("Задача 5.");

int number = 2;
OurPower(number); // вызов метода
OurPower(7); 
OurPower(number + number);
// OurPower(1.5);

void OurPower(int currentNumber)
{
    Console.WriteLine(currentNumber * currentNumber);
}
