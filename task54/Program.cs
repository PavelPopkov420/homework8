Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
for (int i = 0; i< n; i++)
{
    for (int j = 0; j < m; j++)
    {
    matrix[i, j] = new Random().Next(-10, 100);
    Console.Write(matrix[i,j] + " \t");
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m - 1; j++)
    {
        for (int z = 0; z < m - 1; z++)
        {
            if (matrix[i, z] > matrix[i, z + 1])
            {
                int temp = 0;
                temp = matrix[i, z];
                matrix[i, z] = matrix[i, z + 1];
                matrix[i, z + 1] = temp;
            }
           
        } 
    }
}
Console.WriteLine();

for (int i = 0; i< n; i++)
{
    for (int j = 0; j < m; j++)
    {
    Console.Write(matrix[i,j] + " \t");
    }
    Console.WriteLine();
}
