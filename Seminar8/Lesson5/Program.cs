﻿// Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] matrix = new int[4, 4];
FillSpiralMatrix(matrix);
PrintMatrix(matrix);

void FillSpiralMatrix(int[,] matr, int i = 0, int j = 0)
{
    int number = 1;
    while (number <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= matr.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > matr.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write($"0{matr[i, j]} ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
