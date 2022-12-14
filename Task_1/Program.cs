try
{
Console.WriteLine("Введите Количество элементов массива.");
int n = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[n];
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под номером {i}.");
    mass[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.Write("Введеный массив: ");
for (int j = 0; j < mass.Length; j++)
{
    Console.Write($"{mass[j]} ");
}
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"Количество элементов со значением больше нуля {count}.");
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}