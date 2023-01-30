// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];


for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();

int sum = 0;

for (int i = 0; i < num; i++)
{
    if (i % 2 != 0)
    {
        sum += array[i];
    }
}

Console.WriteLine(sum);