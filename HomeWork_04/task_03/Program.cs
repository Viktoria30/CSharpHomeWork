// Задача 29: Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] FillArray(int length)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int length = ReadInt("Введите количество элементов в массиве: ");
int[] array = FillArray(length);
PrintArray(array);
