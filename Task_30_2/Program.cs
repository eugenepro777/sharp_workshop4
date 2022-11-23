// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
PrintArray(array);
Console.WriteLine();
var arr = FillArray(8);
PrintArray(arr);

int[] FillArray(int length) // метод возвращающий целочисленное значение
{
    int[] result = new int[length];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
}