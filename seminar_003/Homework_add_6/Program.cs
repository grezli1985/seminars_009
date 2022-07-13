/* Задача 1. Рассчитать значение y при заданном x по формуле
    /-
y = |   sin  квадрат * x         при x > 0
    |   1-2sin x квадрат         в противном случае
    \-
*/

if(x>0)
{
double y = Math.Pow((sin, 2) * x);
}
else
{
double y = Math.Pow((1 - 2 * sin * x),2);
}
 
Console.WriteLine(y);

