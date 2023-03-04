// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = ReadInt("Введите точку b1: ");
double k1 = ReadInt("Введите точку k1: ");
double b2 = ReadInt("Введите точку b2: ");
double k2 = ReadInt("Введите точку k2: ");

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");