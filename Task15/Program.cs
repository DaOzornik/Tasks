/*  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Enter a number from 1 to 7:");
int a = Convert.ToInt32(Console.ReadLine());

if(a >=1 && a <=7)
{
    if (a == 6 | a == 7) Console.WriteLine("DayOff");
    else Console.WriteLine("work slave the sun is still high");
}
else Console.WriteLine("Enter the right number, dummy!");
