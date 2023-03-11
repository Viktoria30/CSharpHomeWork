// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreatingMatrix1(int numberRows, int numberColumns)
{
    int[,] matrix = new int[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix1(int[,] matrix)
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

int[,] CreatingMatrix2(int numberRows, int numberColumns)
{
    int[,] matrix = new int[numberRows, numberColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix2(int[,] matrix)
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

void NewMatrix(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                    sum += matrix1[i, k] * matrix2[j, k];
            }
            resultMatrix[i,j] = sum;
        }
    }
}

int[,] matrix1 = CreatingMatrix1(2, 3);
PrintMatrix1(matrix1);
System.Console.WriteLine();
int[,] matrix2 = CreatingMatrix2(3, 2);
PrintMatrix2(matrix2);
int[,] resultMatrix = new int [2, 2];
System.Console.WriteLine();
NewMatrix(matrix1, matrix2, resultMatrix);
PrintMatrix1(resultMatrix);
