/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//Console.WriteLine("Enter number");
//int number = Convert.ToInt32(Console.ReadLine());
//int number = 5;
//Console.WriteLine(Math.Pow(number, 3));
//Console.WriteLine($"{number}  в кубе {number*number*number}");

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
//int value = 3;
for (int power = 3; power <= 99; power++)
{
 Console.WriteLine(Math.Pow(number, power));
}
 Console.WriteLine();


