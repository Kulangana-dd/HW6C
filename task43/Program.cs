/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double[] IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double[] y = new double[2];
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 2);
    y[0] = Math.Round((k1 * x + b1), 2);
    y[1] = Math.Round((k2 * x + b2), 2);
    return y;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write("; ");
    }
}

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double[] result = IntersectionPoint(b1, k1, b2, k2);

Console.Write("Координаты точки пересечения двух прямых: ");
PrintArray(result);