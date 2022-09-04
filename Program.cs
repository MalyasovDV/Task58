int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); ++i)
        for (int j = 0; j < matrix2.GetLength(1); ++j)
             for (int k = 0; k < matrix2.GetLength(0); ++k)
                        resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];

    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
                Console.Write(matrix[i,j] + "  ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

void MatrixInitialization(ref int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i,j] = rnd.Next(-10, 10);
                
        
}


Console.WriteLine("Введите размеры матрицы");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] matrix1 = new int[m,n];
int[,] matrix2 = new int[n,m];

MatrixInitialization(ref matrix1);
MatrixInitialization(ref matrix2);

Console.WriteLine("\nМатрица 1");
PrintMatrix(matrix1);

Console.WriteLine("Матрица 2");
PrintMatrix(matrix2);

Console.WriteLine("\nРезультирующая матрица:\n");
PrintMatrix(MatrixMultiplication(matrix1,matrix2));