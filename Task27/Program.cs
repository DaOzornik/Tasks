﻿/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

 Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;

while ( number > 0) 
{

digit += number %10;
number = number/10;

}
Console.WriteLine(number + digit);

