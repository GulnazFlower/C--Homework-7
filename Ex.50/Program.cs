// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void GetElement(int[,] massive, int element)
{
    int count = 0;
    for( int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
             if (massive[i, j] == element)
             {
                count++;
             }  
        }
    }
    if (count == 0)
        {
            Console.WriteLine($"{element} -> такого числа нет в массиве");
        }
    else Console.WriteLine($"{element} -> такое число есть в массиве");      
}
    

void Print2DMassive(int[,] massive)
{
    for( int i = 0; i < massive.GetLength(0); i++)
    {
        for( int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($" {massive[i, j]}\t", -2);
        }
        Console.WriteLine();
    }
}

int[,] Generate2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows,columns];
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
int startValue = GetInput("Введите минимальное число диапазона: ");
int finishValue = GetInput("Введите максимальное число диапазона: ");
int[,] massive = Generate2DMassive(m, n, startValue, finishValue);
Print2DMassive(massive);
int element = GetInput("Введите элемент массива: ");
GetElement(massive, element);
