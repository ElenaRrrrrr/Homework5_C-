// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < array.Length)
    {
        array[i] = new Random().Next(100, 1000);
        i++;
    }
}
void PrintArray(int[] array)
{
    int i = 0;
    int count = array.Length;
    while (i < array.Length)
    {
        Console.WriteLine($"[{array[i]}]");
        i++;
    }
}
void evenNumber(int[] array)
{
    int i = 0;
    int count = array.Length;
    int even_count = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even_count++;
        }
    }
    Console.WriteLine($"Колличество четных эллементов:{even_count}");
}
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine(String.Empty);
evenNumber(array);