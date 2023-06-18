// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Write number:");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
{
    Console.WriteLine($"Your number: {number} - palindrom.");
}
    else Console.WriteLine($"Your number: {number} - nope palindrom.");
}
if (number!.Length == 5)
{
    CheckingNumber(number);
}
else
{
    Console.WriteLine($"Eror, write true number");
}
Console.ReadKey();