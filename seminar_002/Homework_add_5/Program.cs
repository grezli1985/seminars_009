/* Задача 2. На вход подаются год,
номер месяца и день рождения человека,
Определить возраст человека на момент 1 июля 2022 года. */

/*int g;
int m;
int d;
string x = {1,07,2022}; */


Console.WriteLine("Введите год рождения цифрами");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите месяц рождения цифрами");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите день рождения цифрами");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваша дата рождения {c}, {b}, {a}");

DateTime birthdate = new DateTime (a, b, c);
DateTime date1 = new DateTime(2022, 7, 1);
Console.WriteLine(date1.ToShortDateString());

Console.WriteLine($"Ваш возраст {date1.Subtract(birthdate)/365}"); //date1.Subtract(date2)

//Ваш возраст 36.13:24:49.3150685  (36 лет. 13:24:49 время 3150685 ???)