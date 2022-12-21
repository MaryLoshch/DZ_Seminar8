// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.WriteLine("Введите размер квардратного массива (x на x): ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = num;
    num++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else
    if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else
    if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)

                Console.Write($"0{array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nПолученный массив: ");
PrintArray(array);
