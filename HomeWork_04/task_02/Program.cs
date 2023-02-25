// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sum = sum + num;
    }
    return sum;
}
int number = ReadInt("Введите число: ");
System.Console.WriteLine($"Сумма цифр в числе {number} равна {Sum(number)}");