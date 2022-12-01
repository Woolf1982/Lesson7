/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
9 -> 4
5 -> 9
*/

Console.WriteLine("Now you have to enter row and column");
Console.Write("Enter the row: ");
int Position1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter column: ");
int Position2 = Convert.ToInt32(Console.ReadLine()) - 1;
int a = 5;
int b = 7;
Random random = new Random();
int[,] array = new int[a, b];
Console.WriteLine("Randomly generated array: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(10, 99);
        Console.Write("{0}  ", array[i, j]);
    }
    Console.WriteLine();
}
if (Position1 < 0 | Position1 > array.GetLength(0) - 1 | Position2 < 0 | Position2 > array.GetLength(1) - 1)
{
    Console.WriteLine("Element does not exist  ");
}
else
{
    Console.WriteLine("Element by given parameters = {0}", array[Position1, Position2]);
}
Console.WriteLine();
