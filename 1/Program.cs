// Задача 1: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int Num = Prompt("Enter five-digit -> ");
if (Num <= 9999 || Num > 99999)
{
    System.Console.WriteLine("Error");
    Environment.Exit(0);
}

if (Num / 10000 == Num % 10 && Num / 1000 % 10 == Num % 100 / 10) System.Console.WriteLine("OK");
else System.Console.WriteLine("NO");