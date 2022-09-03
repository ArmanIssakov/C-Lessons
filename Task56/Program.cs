// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
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
    int[] sumElemArray = new int[matrix.GetLength(0)];
    int counter = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRowElem = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRowElem += matrix[i, j];
        }
        sumElemArray[counter] = sumRowElem;
        counter++;
    }
    int result = MinIndex(sumElemArray);
    result = result+1; // прибавил 1 для того, чтобы пользователю было понятно, что это 1 строка как у людей, а не как у программистов :))
    Console.WriteLine($"Строка с наименьшей суммой элементов находится под номером {result}");
}

int[,] matr = CreateMatrixRndInt(4, 2, 1, 10);
PrintMatrix(matr);
MaxMin(matr);
// // PrintArray(res);
// Console.WriteLine(res);
int MinIndex(int[] array)
{
int minElem = array[0];
int index = 0;
for (int i = 1; i < array.Length; i++)
{
 if(minElem > array[i])
 {
    minElem = array[i];
    index = i;
 }   

}
return index;
}