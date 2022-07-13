/* Задача 44: 
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */ 


void Zadacha44()
{
    double a = 0;
    double b = 1;
    double count = 60;

    for (int i = 0; i < count; i++)
    {
        Console.Write(a + "\t");
        double temp = b;
        b += a;
        a = temp;
    }
    
}

Zadacha44();