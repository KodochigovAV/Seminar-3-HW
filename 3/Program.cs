// Задача 3: Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int N = Prompt("Enter -> ");

int i = 1;

while(i <= N)
{
    System.Console.WriteLine(i*i*i);
    i++;
}