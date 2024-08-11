void Main()
{
    int rowCount = ReadInt("Введите количество строк двумерного массива ");
    int colCount = ReadInt("Введите количество столбцов двумерного массива ");

    int[,] matrix = GenerateMatrix(rowCount, colCount, 0, 10);
    PrintMatrix(matrix);
    PrintArray(CalkulateAverages(matrix));
    
}

void PrintArray(double[] array)

{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

double[] CalkulateAverages(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(0)];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)

        {
            averages[i] += matrix[i, j];
        }
        averages[i] /= matrix.GetLength(1);
    }

    return averages;
             
}

void PrintMatrix(int[,] matrixForPrint)

{
    for(int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for(int j = 0; j < matrixForPrint.GetLength(1); j++)

        {
            Console.Write(matrixForPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GenerateMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rows, cols];
    Random rand = new Random();

    for(int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < tempMatrix.GetLength(1); j++)

        {
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return tempMatrix;
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();