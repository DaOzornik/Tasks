/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int count = 0;
Console.WriteLine("Сколько чисел требуется ввести?");
int M = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i+1} число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number>0) count++; 
}
    Console.WriteLine("Чисел больше 0: " + count);