// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void ShowRandomArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-99, 100);
        }
        Console.WriteLine($"[{String.Join(",", array)}]");
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = GetInput("Введите размер массива: ");
int[] numbers = new int[size];
ShowRandomArray(numbers);
int count = 0;
for(int i = 0; i < numbers.Length;i++)
{
    if(numbers[i] % 2 == 0)
    count++;
}
Console.Write($"Количество чётных чисел в массиве -> {count}");
