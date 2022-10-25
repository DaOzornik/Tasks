﻿/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, 
                     y = k2 * x + b2= k1 * x + b1; 
                     x = 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int k1 = 5;
int b1 = 2;
int k2 = 9;
int b2 = 4;
if (k1==k2)
{
    Console.WriteLine("Точки пересечения нет");
}
else
{
    double x =(b2-b1)/(k1-k2);
    double y = k1*x+b1;
    double y2 = k2*x+b2;
    Console.WriteLine($"Прямые пересекаются в точке А ({x};{y})");
}
    