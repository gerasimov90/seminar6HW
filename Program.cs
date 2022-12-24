/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Сколько чисел Вы хотите ввести?");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите следующее число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

int count = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0)
    {
        count = count+1;
    }
}
Console.WriteLine($"Введены числа: [{String.Join("; ", array)}]");
Console.WriteLine("Среди введенных чисел, количество положительных: " + count);
*/

/*
Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
*/

Console.WriteLine("Программа вычисляет точку пересечения прямых вида y = K1x + B1 и y = K2x + B2");
Console.WriteLine("Введите коэффициенты первой и второй прямых");
Console.WriteLine("Введите B1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите K1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите K2");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
     Console.WriteLine("Прямые совпадают");
}
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
    
double first = (b2-b1)/(k1-k2);
double second = k1*first + b1;


Console.WriteLine($"Точка пересечения прямых: [{String.Join("; ", first, second)}]");

