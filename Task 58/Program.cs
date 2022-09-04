// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
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
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}
int[,] MatrixMulti(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(0) != matrix2.GetLength(1)) Console.WriteLine("Умножение матриц не возможно");
    int[,] resMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resMatrix[i,j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return resMatrix;
    
}
int[,] matr1 = CreateMatrixRndInt(2, 2, 1, 3);
PrintMatrix(matr1);
Console.WriteLine();
int[,] matr2 = CreateMatrixRndInt(2, 2, 1, 3);
PrintMatrix(matr2);
Console.WriteLine();
int [,] resMatr = MatrixMulti (matr1,matr2);
PrintMatrix(resMatr);