Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c:");
double c = double.Parse(Console.ReadLine());
if ((c * c) == (a * a) + (b * b)) Console.WriteLine("Прямоугольный");
else Console.WriteLine("Не прямоугольный");