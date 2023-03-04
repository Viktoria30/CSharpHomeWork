// Задача 41:** Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

System.Console.WriteLine($"Введите элементы массива: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);


void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int PositivElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

PrintArray(array);
Console.WriteLine($"Количество чисел больше нуля {PositivElement(array)}");

