// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < 1000; i++)
{
    if (number > 1000)
    {
        number = number / 10;
    }
}
if (number > 99 && number < 1000)
{
    int number1 = number % 10;
    System.Console.Write("Третья цифра: " + number1);
}
else
{
    System.Console.Write("третьей цифры нет");
}