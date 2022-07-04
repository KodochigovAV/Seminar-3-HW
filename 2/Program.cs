// Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Enter X1 -> ");
int y1 = Prompt("Enter Y1 -> ");
int z1 = Prompt("Enter Z1 -> ");
int x2 = Prompt("Enter X2 -> ");
int y2 = Prompt("Enter Y2 -> ");
int z2 = Prompt("Enter Z1 -> ");

int A = x1 - x2;
int B = y1 - y2;
int C = z1 - z2;

double L = Math.Sqrt(A * A + B * B + C * C);
System.Console.WriteLine(L);
