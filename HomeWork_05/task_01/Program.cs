// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void SumEvenNumber(int[] array, out int sum)
{
    int count = 0;
    sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    sum = sum + count;
}

const int SIZE = 5;
var myArray = GenerateArray(SIZE);
PrintArray(myArray);
SumEvenNumber(myArray,out int sum);
System.Console.WriteLine($"Количество чётных чисел в массиве: {sum}");
