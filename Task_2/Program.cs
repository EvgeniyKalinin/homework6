Console.WriteLine("Введите значение b1.");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1.");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2.");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2.");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = (-b2 + b1)/(-k1 + k2);
int y = k2 * x + b2;

Console.WriteLine($"Прямые пересекутся в точке с координатами ({x}; {y})");