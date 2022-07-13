/* Задача 1.
На вход подаётся натуральное десятичное число.
Проверьте, является ли оно палиндромом в двоичной записи. */

void Zadacha29()
{
    Console.Write("Введите число ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    BinaryNumeralSystem(number);

    //reverse(number);
    //palindrome(number);
}

void BinaryNumeralSystem(int number)
{
    int resul = 0;
    int num = 0;
    int res = 0;
    while(0 < number)
    {
        int number1 = number / 2;
        int result = number1 * 2;
        res = number - result;
        number = number1;
        Console.Write(res);
        while(res != 0)
        {
            resul = resul * 10 + res % 10;
            res = res / 10;
        }
        Console.Write(resul);
        Console.WriteLine();
    }
    //return resul;
    Console.WriteLine();   
}

// int reverse(int number) 
// {
//     int result = 0;
//     while(number != 0)
//     {
//     result = result * 10 + number % 10;
//     number = number / 10;
//     }
//     Console.Write(result);
//     Console.WriteLine();
//     return result;
// }    
    
    
       


void palindrome(int number)
{
    int digitOnes = number%10;             // 1001111 = 1
    int digitTens = number/10%10;          // 16361/10 = 1636 % 10 = 6
    int digitHundreds = number/100%10;
    int digitThousandUnits = number/1000%10;    // 16361/1000 = 16 % 10 = 6
    int digitTenOfThousands = number/10000;
    int digitHundredsOfThousands = number/100000%10;
    int digitUnitsOfMillions = number/1000000%10;
    int digitTensOfMillions = number/10000000%10;
    Console.WriteLine();
    if(digitOnes == digitTensOfMillions && digitTens == digitUnitsOfMillions && digitHundreds == digitHundredsOfThousands && digitThousandUnits == digitTenOfThousands)
    {
        Console.WriteLine("Число является палиндромом!");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом!");
    }
}

Zadacha29();



