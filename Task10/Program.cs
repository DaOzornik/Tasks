/* Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Input three-digit number:");
int N = Convert.ToInt32(Console.ReadLine());
N = (N%100)/10;
Console.WriteLine($"you've been looking for {N}");