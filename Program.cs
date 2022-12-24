/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.
*/
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
