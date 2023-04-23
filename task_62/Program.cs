// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int n = 4;
int[,] arr = new int[n, n];

int num = 1;
int row = 0;
int col = 0;
int lastRow = n - 1;
int lastCol = n - 1;

while (num <= n * n)
{
// Вправо
for (int i = col; i <= lastCol; i++)
{
arr[row, i] = num;
num++;
}
row++;

// Вниз
for (int i = row; i <= lastRow; i++)
{
arr[i, lastCol] = num;
num++;
}
lastCol--;

// Влево
for (int i = lastCol; i >= col; i--)
{
arr[lastRow, i] = num;
num++;
}
lastRow--;

// Вверх
for (int i = lastRow; i >= row; i--)
{
arr[i, col] = num;
num++;
}
col++;
}

// Вывод массива
for (int i = 0; i < n; i++)
{
for (int j = 0; j < n; j++)
{
Console.Write("{0:D2} ", arr[i, j]);
}
Console.WriteLine();
}






