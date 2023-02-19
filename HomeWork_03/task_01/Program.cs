// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number!.Length != 5)
{
    System.Console.WriteLine("Это не пятизначное число");
}
else if (number![0] == number![4] && number![1] == number![3])
{
    System.Console.WriteLine("Да это палиндром");
}
else
{
    System.Console.WriteLine("Нет это не полиндром");
}