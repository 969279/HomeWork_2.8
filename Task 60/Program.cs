/*
Задача 60. ...Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int rows = ReadInt("Введите число строк: ");
int columns = ReadInt("Введите число столбцов: ");
int layer = ReadInt("Введите число слоёв: ");
int[,,] array = new int[rows, columns, layer];
int[] randomArray = new int[rows * columns * layer];

Random rnd = new Random();

if(rows * columns * layer > 98)
{
    Console.WriteLine("Такой массив создать невозможно.");
    return;
}

Console.WriteLine();
RandomNumberArray(randomArray);
Fill3DArray(array);
Print3DArray(array);

void RandomNumberArray(int[] numbers)
{ 
    int i = 0;
    while(i < numbers.Length)
    {
        int number = rnd.Next(10, 100);
        bool index = true;
               
        for (int j = 0; j < numbers.Length; j++)
        {
            if(number == numbers[j])
            {
                index = false;
                break;
            }       
        }
        if(index)
            {
                numbers[i] = number;
                i++;
            }
    }
}

void Fill3DArray(int[,,] numbers)
{
    int j = 0;
    for (int z = 0; z < numbers.GetLength(2); z++)
    {
        for (int x = 0; x < numbers.GetLength(0); x++)
        {
            for (int y = 0; y < numbers.GetLength(1); y++)
            {
                numbers[x, y, z] = randomArray[j++];
            }
        }
    }
}
    
void Print3DArray(int[,,] numbers)
{ 
    for (int z = 0; z < numbers.GetLength(2); z++)
    {
        for (int x = 0; x < numbers.GetLength(0); x++)
        {
            for (int y = 0; y < numbers.GetLength(1); y++)
            {
                Console.Write(numbers[x, y, z]);
                Console.Write($"({x},{y},{z}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

