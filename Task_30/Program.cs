// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];//массив целых чисел из 8 элементов

PrintArray(array);
Console.WriteLine();
FillArray(array);
PrintArray(array);

void FillArray(int[] arr) // int если действия с массивом
// надо выполнять, метод void не возвращает значение
{
    for(int i=0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)// int если действия с массивом надо выполнять
{
    for(int i=0; i < arr.Length; i++)
    {
    Console.Write($"{arr[i]}, ");
    }
}
