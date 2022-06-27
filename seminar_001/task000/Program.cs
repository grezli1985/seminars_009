// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// int number = 5; // integer
Console.WriteLine("Введите число которое возвести в квадрат");
int number = Convert.ToInt32(Console.ReadLine()); // 32 бит, 64 бит
// Console.WriteLine(number*number);
Console.WriteLine(Math.Pow(number, 2));
// Console.WriteLine("5 квадрате равно" + Math.Pow(number, 2));
Console.WriteLine($"{number} квадрате равно {number*number}");
//
