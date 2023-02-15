// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    int number2 = number / 10;
    int number3 = number2 % 10;
    System.Console.Write("Вторая цифра трехзначного числа = " + number3);
}
else
{
    System.Console.Write("Введено не трехзначное число");
}
