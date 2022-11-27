/*
Доп. задача 55**: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя. 
Решить НЕ используя второй массив
*/

int rows = ReadInt("Введите число строк: ");
int columns = ReadInt("Введите число столбцов: ");
int[,] array = new int[rows, columns];
int temp = 0;

if(rows == columns)
{
    Fill2DArray(array);
    Write2DArray(array);
    Console.WriteLine();
    ChangeNumbers(array);
    Write2DArray(array);
 } else
 
Console.WriteLine("Замена строк на столбцы невозможна");

void ChangeNumbers(int[,] numbers)
{
for (int k = 0; k < numbers.GetLength(1) - 1; k++)
{
    for (int i = k; i < numbers.GetLength(0); i++)
    {
     for (int j = k++; j < numbers.GetLength(1); j++)
        {
         temp = numbers[i, j];
         numbers[i, j] = numbers[j, i];
         numbers[j, i] = temp;
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
        numbers[i, j] = new Random().Next(1, 10);
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}