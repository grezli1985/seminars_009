/* Задача 42: 
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10    */ 

void Zadacha42()
{
    Console.Write("Введите число = ");
    int  number = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int bias = 1;

    while(number > 0)
    {
        result += number % 2 * bias;
        bias *= 10;
        number /= 2;
    }
    Console.WriteLine(result);

}

Zadacha42();


