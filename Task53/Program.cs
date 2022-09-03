// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int [,] CreateMatrixRndInt (int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i,j] = rnd.Next(min, max);
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
            Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine("]");
    }
}
void Swarp (int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int buff = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = buff;
    }
}
int [,] matr = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matr);
Swarp(matr);
Console.WriteLine();
PrintMatrix(matr);