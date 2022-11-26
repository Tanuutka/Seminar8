// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.Write("Задайте число строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Задайте число столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


void FillArray(int[,] array)
{
    Random generator = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = generator.Next(1, 11);
        }
    }
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

int minSumRows(int[,] array)

{
    int minRow = 1;
    int minSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSum = minSum + array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < minSum) minRow = i + 1;

    }
    return minRow;
}

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.Write("Номер строки с наименьшей суммой:  " + minSumRows(array));

