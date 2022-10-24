/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


Console.WriteLine("Задайте количество строк двумерного массива:");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[line, colums];
Random rnd = new Random();

void PrintArray(double[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
 Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
        }
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);
