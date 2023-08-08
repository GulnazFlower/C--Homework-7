// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print2DMassive(double[,] massive)
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

double[,] Generate2DMassive(int rows, int columns, int startValue, int finishValue)
{
    double[,] matrix = new double[rows,columns];
    Random rand = new Random();
    for( int i = 0; i < matrix.GetLength(0); i++)
    {
        for( int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rand.Next(startValue, finishValue + 1)*0.1, 1);
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
double[,] massive = Generate2DMassive(m, n, startValue, finishValue);
Print2DMassive(massive);