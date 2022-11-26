// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
Console.Write("Задайте число строк первого массива: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Задайте число столбцов первого массива: ");
int columnsA = int.Parse(Console.ReadLine());
int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
PrintArray(arrayA);
Console.WriteLine();

Console.Write("Задайте число строк второго массива: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Задайте число столбцов второго массива: ");
int columnsB = int.Parse(Console.ReadLine());
int[,] arrayB= GetArray(rowsB, columnsB, 0, 10);

PrintArray(arrayB);
Console.WriteLine();

if (columnsA!=rowsB)
{
  Console.Write("Такие матрицы умножать нельзя!");  
  return;
}


PrintArray(GetMultiplicationMatrix(arrayA,arrayB));

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max);
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

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB )
{
    int[,] arrayC= new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
       for (int j = 0; j < arrayB.GetLength(1); j++) 
       {
        for (int k = 0; k < arrayA.GetLength(1); k++) 
        {
            arrayC[i,j]+=arrayA[i,k]*arrayB[k,j];
        }
       }
    }
    return arrayC;
}




