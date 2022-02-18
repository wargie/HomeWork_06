//Задача 44.Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.
// k1*x+b1=k2*x+b2
//выразим отсюда x=(b2-b1)/(k1-k2)
//затем подставим полученное значение х в выражение для y=k1(b2-b1)/(k1-k2)+b1


Console.Write("Введите значение b1: ");
var b1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
var b2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k1: ");
var k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
var k2 = int.Parse(Console.ReadLine());

var x = (b2 - b1)/(k1 - k2);
var y = (k1 * (b2 - b1)/(k1 - k2) + b1);

Console.WriteLine($"Координата точки пересечения прямых равна {x} и {y}");