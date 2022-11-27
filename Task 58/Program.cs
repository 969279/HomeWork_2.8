/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rows1 = ReadInt("Введите число строк массива №1: ");
int columns1 = ReadInt("Введите число столбцов массива №1: ");
int rows2 = ReadInt("Введите число строк массива №2: ");
int columns2 = ReadInt("Введите число столбцов массива №2: ");
int[,] array1 = new int[rows1, columns1];
int[,] array2 = new int[rows2, columns2];
int[,] array3 = new int[rows1, columns2];

//int[,] array1 = {{2, 4}, {3, 2}};
//int[,] array2 = {{3, 4}, {3, 3}};
//int[,] array3 = new int[2, 2];

if(columns1 == rows2)
{
    Fill2DArray(array1);
    Fill2DArray(array2);
    Write2DArray(array1);
    Console.WriteLine();
    Write2DArray(array2);
    Console.WriteLine();
    ProdArray(array1, array2, array3);
    Write2DArray(array3);
} else  Console.WriteLine("Произведение введенных матриц невозможно");


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

void ProdArray(int[,] arr1, int[,] arr2, int[,] arr3)
{
for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
           for (int k = 0; k < arr2.GetLength(0); k++)
           {
                arr3[i, j] += arr1[i, k] * arr2[k, j];
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
