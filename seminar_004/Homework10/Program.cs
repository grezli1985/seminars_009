/*Задача 25: Напишите цикл, который принимает на вход
два натуральных числа (A и B) и возводит число A в
степень B. 
3, 5 -> 243 (3⁵)
2, 4 -> 16         */ 

void Zadacha25()
{
    
Console.Write("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"возводим число {numberA} в степень {numberB} = {Exponentiation(numberA, numberB)}");

// Console.WriteLine($"возводим число  {numberA} в степень {numberB} равно {Math.Pow(numberA, numberB)}");

}

//3, 5 -> 243 (3⁵)        3           5
int Exponentiation(int numberA, int numberB)
{  
        int result = 1; 
        int i = numberB;
        while (i > 0)
        {
            result = result * numberA;
            i--;
        }
        return result;
        
}

Zadacha25();