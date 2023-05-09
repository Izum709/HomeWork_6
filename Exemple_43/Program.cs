// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 



double EnterData(string text)
{
    Console.WriteLine(text);
    return(Convert.ToInt32(Console.ReadLine()));
}

double b1 = EnterData("Введите значение b1: ");
double b2 = EnterData("Введите значение b2: ");
double k1 = EnterData("Введите значение k1: ");
double k2 = EnterData("Введите значение k2: ");
double x = -(b1 - b2) / (k1-k2);
double y = k1 * x + b1;

Console.Write($" Точка пересечения двух прямых: ({x}; {y})");