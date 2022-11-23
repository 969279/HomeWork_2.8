/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int rows = 4, columns = 5;
int[,] array = new int[rows, columns];
int [,] decreasingArray = new int[columns, rows];

Fill2DArray(array);
Write2DArray(array);
Console.WriteLine();
SortArray(array);
Write2DArray(array);

void SortArray(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
       for (int j = 0; j < number.GetLength(1); j++)
       {
            for (int l = 0; l < number.GetLength(1); l++)
            { 
                if (number[i, l] < number[i, j])
                {
                   int temp = number[i, j];
                   number[i, j] = number[i, l];
                   number[i, l] = temp;
                }
            }
        }
    } 
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
     for (int j = 0; j < numbers.GetLength(1); j++)
        {
        numbers[i, j] = new Random().Next(0, 10);
        }
    }
}

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
