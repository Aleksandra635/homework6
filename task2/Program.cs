//  Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//   значения b1, k1, b2 и k2 задаются пользователем.

int b1 = Prompt("Введите значение b1: ");
int k1 = Prompt("Введите значение k1: ");
int b2 = Prompt("Введите значение b2: ");
int k2 = Prompt("Введите значение k2: ");
Search (b1,b2,k1,k2);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}  

void Search (int b1, int b2, int k1, int k2)
{
double x = (b2 - b1) / (double)(k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения: ({x}, {y})");
}

