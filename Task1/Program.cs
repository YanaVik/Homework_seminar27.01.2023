// Задача 34.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];


for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();

int count = 0;

for (int i = 0; i < num; i++)
{
    if (array[i] % 2 == 0)
    {
        count ++;
    }
}

Console.WriteLine(count);