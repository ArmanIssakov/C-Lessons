// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет
int[,] CreateMatrixRndIn(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}
void VerifyElement(int row, int col, int[,] matrix)
{
    int i = row - 1;
    int j = col - 1;
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) 
    {
        int element = matrix[i, j];
        Console.WriteLine(element);
    }
    else Console.WriteLine("Такого элемента нет в массиве");
}
int[,] matr = CreateMatrixRndIn(4, 4, 1, 100);
PrintMatrix(matr);
// int element = matr[3, 3];
// Console.WriteLine(element);
// Console.WriteLine(matr[4,4]);
VerifyElement(5, 3, matr);