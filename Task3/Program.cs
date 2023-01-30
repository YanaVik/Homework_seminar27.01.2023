// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
int min = 0;
int max = 0;

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();

int dif = 0;

for (int i = 0; i < num; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] <min)
    {
        min = array[i];
    }
}

Console.WriteLine(dif = max -min);