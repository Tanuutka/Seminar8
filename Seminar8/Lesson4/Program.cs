// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить 
//массив, добавляя индексы каждого элемента
Console.Clear();

int[,,] cube = new int[2, 2, 2];
FillCube(cube);
PrintCube(cube);


int[] CubeToArray(int[,,] matr)
{
    int[] matrToArray = new int[matr.GetLength(0)* matr.GetLength(1)* matr.GetLength(2)];
    int index = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matrToArray[index] = matr[i, j, k];
                index++;
            }
        }
    }
    return matrToArray;
}

void FillCube(int[,,] matr)
{
    int[] cubeArray = CubeToArray(matr);
    Random generator = new Random();
    int indexArray = 0;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = generator.Next(10, 100);
                while (cubeArray[indexArray] == matr[i, j, k])
                    matr[i, j, k] = generator.Next(10, 100);
                indexArray++;
            }
        }
    }
}

void PrintCube(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
