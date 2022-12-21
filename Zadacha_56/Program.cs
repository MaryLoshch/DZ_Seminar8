// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обозначьте диапазон значений внутри массива: от 1 до");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Полученный массив: ");
CreateArray(array);
PrintArray(array);

int min = 0;
int sum = SumNums(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSum = SumNums(array, i);
    if (sum > tempSum)
    {
        sum = tempSum;
        min = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {min + 1} \n(Сумма равна {sum})  ");


int SumNums(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(size);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
