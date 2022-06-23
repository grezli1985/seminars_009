// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

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
