// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// // 10 6 24 49

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, m];
void Matrix1(int[,] matrix1){
    for (int i = 0; i<m; i++){
        for (int j = 0; j < n; j++){
            matrix1[i,j] = new Random().Next(0, 10);
            Console.Write(matrix1[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}
void Matrix2(int[,] matrix2){
    for (int i = 0; i<n; i++){
        for (int j = 0; j < m; j++){
            matrix2[i,j] = new Random().Next(0, 10);
            Console.Write(matrix2[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}
Matrix1(matrix1);
Console.WriteLine();
Matrix2(matrix2);
int[,] result = new int[m, m]; 

for (int i = 0; i<n; i++){
    for (int j = 0; j < m; j++){
        int sum = 0;
        for (int k = 0; k < n; k++)
        {
            sum += matrix1[i,k] * matrix2[k,j];
            
        }
        result[i,j] = sum;   
    }
}
Console.WriteLine();
for (int i = 0; i<n; i++){
    for (int j = 0; j < m; j++){
        Console.Write(result[i,j] + " ");
            
    }
    Console.WriteLine();
}