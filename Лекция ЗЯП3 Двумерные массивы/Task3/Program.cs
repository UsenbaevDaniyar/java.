int[,] GreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void shouMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GreateMatrix(3, 4);
shouMatrix(matrix);

foreach (int e in matrix)
{
    if(isInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
    int sumOffDigits = getSumOffDigits(value);
    if(sumOffDigits % 2 == 0)
    {
        return true;
    }
        return false; 
}

int getSumOffDigits (int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
        return sum;
}

