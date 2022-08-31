double[,] CreateMatrixRndDouble(int row, int col)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rnd.NextDouble();
            matrix[i, j] = matrix[i, j] * 10;
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, 7");
            else Console.Write($"{matrix[i, j]}, 3");
        }
        Console.WriteLine("]");
    }
}
double[,] matr = CreateMatrixRndDouble(4, 4);
PrintMatrix(matr);
