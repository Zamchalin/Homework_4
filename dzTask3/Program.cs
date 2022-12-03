// Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] array = new int [8];
for(int i = 0; i < 8; i++)
{
    Console.Write("Введите элемент массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    array[i] = n;
}
Console.WriteLine($"[{string.Join(" , ", array)}]");