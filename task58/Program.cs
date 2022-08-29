Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[n, m];
int[,] matrixB = new int[n, m];

int[,] matrixC = new int[n, m];

for (int i = 0; i< n; i++)
{
    for (int j = 0; j < m; j++)
    {
    matrixA[i, j] = new Random().Next(-10, 10);
    Console.Write(matrixA[i,j] + " \t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i< n; i++)
{
    for (int j = 0; j < m; j++)
    {
    matrixB[i, j] = new Random().Next(-10, 10);
    Console.Write(matrixB[i,j] + " \t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {        
         matrixC[i, j] = matrixA[i, j] * matrixB[i, j];
        Console.Write(matrixC[i,j] + " \t");
    }
     Console.WriteLine();
}