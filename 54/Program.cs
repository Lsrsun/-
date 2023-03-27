// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы
// каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

// строка*столбец

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[m, n];
void InputMatrix(int[,] matrix){
    for (int i = 0; i<m; i++){
        for (int j = 0; j < n; j++){
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write(matrix[i,j] + " ");
            
        }
        Console.WriteLine();
    }
}
InputMatrix(matrix);

for (int i = 0; i<m; i++){
    for (int j = 0; j < n-1; j++){
        for (int z = 0; z < n - 1; z++)
        {
            if (matrix[i, z + 1] < matrix[i, z]) 
            {
                int temp = 0;
                temp = matrix[i, z + 1];
                matrix[i, z + 1] = matrix[i, z];
                matrix[i, z] = temp;
            }
        }
        
           
    }
}
Console.WriteLine();
for (int i = 0; i<m; i++){
    for (int j = 0; j < n; j++){
        //matrix[i,j] = new Random().Next(0, 10);
        Console.Write(matrix[i,j] + " ");
            
    }
    Console.WriteLine();
}