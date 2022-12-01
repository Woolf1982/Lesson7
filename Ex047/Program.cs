/* Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/

Console.Write("Number of row: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] GetArray(int rows, int columns, int min, int max)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double realNumber;
            Random rnd = new Random();
            realNumber = rnd.NextDouble();
            result[i, j] = new Random().Next(min, max) + realNumber;
            result[i, j] = Math.Round(result[i, j], 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

