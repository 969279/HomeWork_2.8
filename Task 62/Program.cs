/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int n = ReadInt("Введите размер матрицы: ");
int[,] array = new int[n, n];
int number = 1;
int i = 0, j = 0;

while(number <= n * n)
{
    array[i, j] = number++;

    if(i <= j + 1 && j + i < n - 1)
    {
        j++;
    } 
    else if(i < j && i + j >= n - 1)
    {
        i++;
    } 
    else if(i >= j && i + j > n - 1)
    {
        j--;
    } else 
        i--;
    
}

Write2DArray(array);

void Write2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

