// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double INput(string nameSpace)
{
    System.Console.WriteLine(nameSpace);
    double per1 = Convert.ToDouble(Console.ReadLine());
    return per1;
}

double b1 = INput("начало первой линии");
double k1 = INput("конец первой линии");
double b2 = INput("начало второй линии");
double k2 = INput("конец второй линии");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

System.Console.WriteLine($"точка пересечения двух прямых({x},{y})");