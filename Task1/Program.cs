// 

int [] InitArray(int length)
{
    int [] arr = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}

int GetPositiveSummFromArray(int [] arr)
{
    int summ = 0;

    foreach(int item in arr)
    {
        if(item > 0);
            summ += item;
    }
    return summ;
}

int GetNegativeSummFromArray(int [] arr)
{
    int summ = 0;

    foreach(int item in arr)
    {
        if(item < 0);
            summ += item;
    }
    return summ;
}

void PrintArray(int [] arr)
{
    foreach(int item in arr)
        Console.WriteLine($"{item}");
}

(int, int)GetSummsFromArray(int [] arr)
{
int positiveSumm = 0;
int negativeSumm = 0;

foreach(int item in arr)
{
    if(item > 0)
        positiveSumm += item;
    else
        negativeSumm += item;
}

return (positiveSumm, negativeSumm);
}

Console.WriteLine("Введите размерность массива: ");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив: ");
PrintArray(arr);

int positiveSumm = GetPositiveSummFromArray(arr);
int negativeSumm = GetNegativeSummFromArray(arr);

(positiveSumm, negativeSumm) = GetSummsFromArray(arr);

Console.WriteLine("Вызвали метод под звездочкой");
Console.WriteLine($"Положительная сумма: {positiveSumm}. Отрицательная сумма: {negativeSumm}");