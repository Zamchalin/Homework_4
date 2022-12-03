// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Length = 1;
int result = 0;
int copyN = n;

while( copyN / 10 != 0)
{
    copyN /= 10;
    Length++;
}
for (int i = 0; i < Length; i++)
    {
        result = n % 10 + result;
        n = n / 10;
    }
    Console.WriteLine($"Результат: {result}");
