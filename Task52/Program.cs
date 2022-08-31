// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void Arif(int[,] matrix)
{
    // int k = matrix.GetLength(1);
    int[] array = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = j;

            if (j == k) array[k] = array[k] + matrix[i, j];
            
            Console.Write($"{array[k]},");
            
            // k++;


        }
        Console.WriteLine("последние цифры являются суммой чисел в столбцах это пока, что я смог сделать");
    }


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
int[,] matr = CreateMatrixRndIn(3, 6, 1, 10);
PrintMatrix(matr);
Arif(matr);
// Эту задачу я не успел выполнить в срок, постараюсь сдать вместе со следующим дз.
