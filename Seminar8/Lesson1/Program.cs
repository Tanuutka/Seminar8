// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.Write("Задайте число строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Задайте число столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintArray(int[,] Printarray)
{
   
    for (int i = 0; i < Printarray.GetLength(0); i++)
    {
        for (int j = 0; j < Printarray.GetLength(1); j++)
        {
            Console.Write($"{Printarray[i, j]} ");

        }
        Console.WriteLine();
    }
}


void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = j + 1; t < array.GetLength(1); t++)
            {
                if (array[i, t] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temp;
                }
            }
        }
    }
}

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);