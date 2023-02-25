// Задача 25: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Natural(int a, int b)
{
    int num = a;
    for (int i = 1; i < b; i++)
    {
        num = num * a;
    }
    return num;
}
bool Examination(int b)
{
    if (b < 0)
    {
        System.Console.WriteLine("Показатель должен быть больше нуля");
        return false;
    }
    return true;
}

int a = ReadInt("Введите число А: ");
int b = ReadInt("Введите число В: ");
if (Examination(b))
{
    System.Console.WriteLine($"Число {a} в степени {b} равно {Natural(a, b)}");
}





