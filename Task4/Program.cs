/* Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int [] InitArray(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-9, 200);
    }
    return arr;
}

int GetFindNumbers(int [] array)
{
    int count = 0;
    foreach(int item in array)
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99);
            count++;
    }
    return count;
}

void PrintArray(int [] arr)
{
    foreach(int item in arr)
        Console.WriteLine($"{item}");
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив: ");
PrintArray(arr);

int count = GetFindNumbers(arr);
Console.WriteLine($"Количество искомых элементов: {count}");
