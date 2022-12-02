// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.Write("Введите К1: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите К2: ");
float k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
float x = (b2 - b1) / (k1 - k2);
float y = k1 * x + b1;
Console.WriteLine($"Координаты пересечения двух прямых: x={x}, y={y}");
