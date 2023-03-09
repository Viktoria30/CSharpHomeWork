// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
    return matrix;
}

int FindElementMatrix(int[,] matrix,int m,int n)
{
    int element = matrix[m, n];
    for(int i = 0; i < matrix.GetLength(0); i++ )
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[m, n] == matrix[i, j])
            {
                Console.WriteLine($"Значение элемента в массиве: {matrix[m,n]}");
            }
        }
    }
    return element;
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

System.Console.WriteLine("Введите индекс строки матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите индекс столбца матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] matrix = CreateMatrix(3, 4);
PrintMatrix(matrix);
FindElementMatrix(matrix, m, n);
