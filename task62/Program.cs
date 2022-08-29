int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

int num = 1;
int a = 0;
int b = 0;

while (num <= n * n)
{
    matrix[a, b] = num;
    if (a <= b + 1 && a + b < n - 1)
        ++b;
    else if (a < b && a + b >= n - 1)
        ++a;
    else if (a >= b && a + b > n - 1)
        --b;
    else
        --a;
    ++num;
}
for (int i = 0; i< n; i++)
{
    for (int j = 0; j < n; j++)
    {
      Console.Write(matrix[i,j] + " \t");
    }
    Console.WriteLine();
}