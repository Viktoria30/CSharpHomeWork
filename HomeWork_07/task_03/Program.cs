// Задача 52.** Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageColumn(int[,] matrix, int m, int n)
{
    double[] ArMe = new double [n];
    for (int j = 0; j < matrix.GetLength(1); j++)
    { 
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average = (average + matrix[i,j]);
        }
        average = average/m;
        ArMe[j] = Math.Round((average), 2);
    }
    return ArMe;
}

System.Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);

double[] aver = AverageColumn(matrix, m, n);
Console.WriteLine("[" + string.Join(", ", aver) + "]");
