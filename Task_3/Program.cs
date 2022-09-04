// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите число строк 1-й матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов 2-й матрицы: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
GetArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, z];
GetArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m, z];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}