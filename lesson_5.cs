/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int[] CreateRandomArray(int start, int end)
{
    Console.Write("Введите количество элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int[] RandomArray = new int[N];
    for (; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end+1);
    }
    return RandomArray;
}

int CountEvenNum(int[] Array)
{
    int N = Array.Length, i = 0, count = 0;
    for (; i < N; i++)
    {
        if (Array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Clear();
int[] Array = CreateRandomArray(100, 1000);
int count = CountEvenNum(Array);
Console.WriteLine($"Количество четных чисел в массиве = {count}");
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray(int start, int end)
{
    Console.Write("Введите количество элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int[] RandomArray = new int[N];
    for (; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end+1);
    }
    return RandomArray;
}

int CountOddNumPosition(int[] Array)
{
    int N = Array.Length, i = 0, sum = 0;
    for (; i < N; i += 2) // первое число массива имеет индекс 0, но стоит на 1ой позиции
    {
        sum += Array[i];
    }
    return sum;
}

Console.Clear();
int[] Array = CreateRandomArray(100, 1000);
int sum = CountOddNumPosition(Array);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {sum}");
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] CreateArray()
{
    Console.Write("Введите количество элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    double[] Array = new double[N];
    Console.WriteLine("Заполните массив: ");
    for (; i < N; i++)
    {
        Array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return Array;
}

double Diff(double[] Array)
{
    int N = Array.Length, i = 1;
    double min, max;
    min = Array[0]; max = Array[0];
    for (; i < N; i ++)
    {
        if (Array[i] < min) min = Array[i];
        else if (Array[i] > max) max = Array[i];
    }
    return max - min;
}

void ShowArray(double[] Array)
{
    int N = Array.Length;
    int i = 0;
    Console.WriteLine("Введенный массив: ");
    for (; i < N; i++)
        Console.Write(Array[i] + " ");
    Console.WriteLine();
}

Console.Clear();
double[] MyArray = CreateArray();
ShowArray(MyArray);
double diff = Diff(MyArray);
Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff}");


