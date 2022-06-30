/* Задача 21: Напишите программу, 
которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D 
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/ 


void Zadacha21()
{
    // x1=9 y1=5 x2=3 y2=6
    Console.WriteLine("Введите число x1 ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число y1 ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число x2 ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число y2 ");
    int y2 = Convert.ToInt32(Console.ReadLine());

    double c = Math.Sqrt(Math.Pow((y2-y1),2)+Math.Pow((x2-x1),2));
    Console.WriteLine(c);
}

Zadacha21(); // x1 = 9 y1 = 3 x2 = 5 y2 = 6