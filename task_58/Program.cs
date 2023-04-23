// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrix1 = new int[,] 
{ 
    { 2, 4 }, 
    { 3, 2 } 
};
int[,] matrix2 = new int[,] 
{ 
    { 3, 4 }, 
    { 3, 3 } 
};
int[,] resultMatrix = new int[2, 2];

for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 2; j++)
{
int sum = 0;
for (int k = 0; k < 2; k++)
{
sum += matrix1[i, k] * matrix2[k, j];
}
resultMatrix[i, j] = sum;
}
}

// Вывод результирующей матрицы
for (int i = 0; i < 2; i++)
{
for (int j = 0; j < 2; j++)
{
Console.Write(resultMatrix[i, j] + " ");
}
Console.WriteLine();
}









