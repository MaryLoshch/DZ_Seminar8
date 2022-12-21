// Сформируйте трёхмерный массив из неповторяющихся (HARD - случайные уникальные) двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение l: ");
int l = Convert.ToInt32(Console.ReadLine());


int[,,] newArray = new int[m, n, l];
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Полученный массив: ");
CreateArray(newArray);
PrintArray(newArray);



void CreateArray(int[,,] newArray)
{
    int[] temp = new int[newArray.GetLength(0) * newArray.GetLength(1) * newArray.GetLength(2)];
    int num;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        num = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    num = temp[i];
                }
                num = temp[i];
            }
        }
    }
    int count = 0;
    for (int m = 0; m < newArray.GetLength(0); m++)
    {
        for (int n = 0; n < newArray.GetLength(1); n++)
        {
            for (int l = 0; l < newArray.GetLength(2); l++)
            {
                newArray[m, n, l] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {

            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                Console.Write($"{newArray[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}