/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int size = 4; // создала массив задала размерность
int[] array = new int[size]; //  создала массив
Random rand = new Random(); 
for(int i =0; i<size; i++)
{
   array[i] = rand.Next(100 , 1000); // заполнила массив случайными  положительными трехзначными числами
}
for(int i =0; i<size; i++)
{
   Console.Write(array[i] + " "); // напечатала массив в консоль
}
   Console.WriteLine();

int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 0)
count++;

Console.WriteLine($"всего {array.Length} чисел, {count} из них чётные");



