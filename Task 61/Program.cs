/*
Доп. задача 61*: Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/

int i = ReadInt("Введите количество строк треугольника паскаля: ");
int[,] array = new int[i, 2*i - 1];

Fill2DArray(array);
MakeTriangle(array);
Write2DArray(array);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void MakeTriangle(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int position = 0;
        for (int j = numbers.GetLength(1) - 1; j >= 0; j--)
        {
            if(numbers[i, j] != 0)
            {
                numbers[i, numbers.GetLength(1) / 2 + j - position] = numbers[i, j];
                numbers[i, j] = 0;
                position++;
            }
        }
        numbers[numbers.GetLength(0) - 1, 0] = 1;
    }
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        numbers[i, 0] = 1;
    }
    for (int k = 1; k < numbers.GetLength(0); k++)
    {
        for (int l = 1; l < k + 1; l++)
        {
            numbers[k, l] = numbers[k - 1, l] + numbers[k - 1, l - 1];
        }
    }
}

void Write2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if(numbers[i, j] != 0)
            {
                Console.Write($"{numbers[i, j]}");
            } else Console.Write(" ");
         }
        Console.WriteLine();
    }
}
