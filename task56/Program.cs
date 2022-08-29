Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

int index = 0;
int minsum = 0;

for (int i = 0; i< matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
    matrix[i, j] = new Random().Next(-10, 10);
    Console.Write(matrix[i,j] + " \t");
    }
    Console.WriteLine();
}


for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}
Console.WriteLine("строка с наименьшей суммой елементов под номером: " + index + ", с суммой елементов равной: " + minsum)