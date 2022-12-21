// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("Введите значение m (Число строк первой матрицы): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n (Количество столбцов первой матрицы, которое равно количеству строк второй матрицы): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение l (Количество столбцов второй матрицы): ");
int l = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Обозначьте диапазон значений внутри матриц: от 1 до");
int size = Convert.ToInt32(Console.ReadLine());


int[,] first = new int[m, n];
CreateArray(first);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Первая матрица:");
PrintArray(first);

int[,] secomd = new int[n, l];
CreateArray(secomd);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nВторая матрица:");
PrintArray(secomd);

int[,] result = new int[m,l];

NewMatrix(first, secomd, result);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nПроизведение первой и второй матриц:");
PrintArray(result);

void NewMatrix(int[,] first, int[,] secomd, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < first.GetLength(1); k++)
      {
        sum += first[i,k] * secomd[k,j];
      }
      result[i,j] = sum;
    }
  }
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

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}