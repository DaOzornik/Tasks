/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/* Console.WriteLine("Input number:");
int N = Convert.ToInt32(Console.ReadLine());

if(N >= 99)
{
    Console.WriteLine((N  / 100) %10);
}

else
{
    Console.WriteLine("there is no third digit");
}
*/

Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
string nText = Convert.ToString(n);

if (nText.Length > 2)
{
Console.WriteLine("Третья цифра - " + nText[2]);
}
else
{
Console.WriteLine("Третьей цифры нет");
}



