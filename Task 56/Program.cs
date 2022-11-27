/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int rows = ReadInt("Введите число строк: ");
int columns = ReadInt("Введите число столбцов: ");

int[,] array = new int[rows, columns];
int[] sum = new int[rows];

Fill2DArray(array);
Write2DArray(array);
Console.WriteLine();
SortArray(array, sum);

int index = 0;
int min = sum[0];
for (int i = 0; i < sum.Length; i++)
{
    if(min > sum[i])
    {
        min = sum[i];
        index = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {index + 1}");

void SortArray(int[,] number, int[] sum)
{
   for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
            { 
                sum[i] = number[i, j] + sum[i];
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

void Write2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
