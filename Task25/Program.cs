/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 
*/

Console.WriteLine("Введите первое число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
int count = firstnumber;


for(int i = 1; i < secondnumber; i++ );
{
    Console.WriteLine(Math.Pow(count, secondnumber));
}
