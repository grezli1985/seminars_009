/* Задача 40: 
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длины 

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.   */ 

void Zadacha40()
{
    Console.Write("Первая сторона треугольника ab = ");
    int ab = Convert.ToInt32(Console.ReadLine());
    Console.Write("Вторая сторона треугольника bc = ");
    int bc = Convert.ToInt32(Console.ReadLine());
    Console.Write("Третья сторона треугольника ac = ");
    int ac = Convert.ToInt32(Console.ReadLine());
    IsTriangle(ab, bc, ac);
}

void IsTriangle(int ab, int bc, int ac)
{
    if(ab < bc + ac && ac < ab + bc && bc < ab + ac)
    {
        Console.WriteLine("Треугольник существует");
    }
    else Console.WriteLine("Треугольник не существует");
    
    
}



void Zadacha40_1()
{
    int number1 = 5;
    int number2 = 3;
    int number3 = 4;
    if (CheckSum(number1, number2, number3))
        {
            Console.WriteLine("Треугольник существует");
        }
        else Console.WriteLine("Треугольник нет");
}

bool CheckSum(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}




void Zadacha40_2()
{
    int number1 = 5;
    int number2 = 3;
    int number3 = 4;
    if (CheckSum(number1, number2, number3) &&
        CheckSum(number1, number3, number2) &&
        CheckSum(number2, number3, number1))
        {
            Console.WriteLine("Треугольник существует");
        }
        else Console.WriteLine("Треугольник нет");
}

bool CheckSum(int a, int b, int c)
{
    return a + b > c;
}




//Zadacha40();
//Zadacha40_1();
Zadacha40_2();