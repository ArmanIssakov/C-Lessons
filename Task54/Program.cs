// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
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
void MaxMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                    if (matrix[i, j] > matrix[i, k])
                    {
                        int buff = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = buff;
                    }


            }

        }
    }
}
//Сортировка по убыванию по колонкам:
// void MaxMin (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) ; i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(0) ; k++)
//             {
//                 if(matrix[i,j] > matrix[k,j])
//                 {
//                     int buff = matrix[i,j];
//                     matrix[i,j] = matrix[k,j];
//                     matrix[k,j] = buff;
//                 }
//             }

//         }
//     }
// }
int[,] matr = CreateMatrixRndInt(3, 6, 1, 10);
PrintMatrix(matr);
MaxMin(matr);
Console.WriteLine();
PrintMatrix(matr);