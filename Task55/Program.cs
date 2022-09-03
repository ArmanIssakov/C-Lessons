// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
//Первый способ решения:
// int[,] ChangeRowofCol(int[,] matrix)
// {
//     if(matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("rows != column");
//     int[,] buff = new int[matrix.GetLength(0),matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {

//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             buff[i, j] = matrix[j, i];
            
//         }
//     }
//     return buff;
// }
//Второй способ решения:
void ChangeRowofCol(int[,] matrix)
{
    if(matrix.GetLength(0) != matrix.GetLength(1)) Console.WriteLine("rows != column");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {

            int buff = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = buff;
            
        }
    }
}
int[,] matr = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matr);
ChangeRowofCol(matr);
Console.WriteLine();
PrintMatrix(matr);