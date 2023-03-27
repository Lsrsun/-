// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] matrix = new int[m, n, p];
void InputMatrix(int[,,] matrix){
    for (int i = 0; i<m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < p; k++){
                matrix[i,j,k] = new Random().Next(0, 10);
                Console.Write(matrix[i,j,k] + $"({i}, {j}, {k})" + " ");
            }
            Console.WriteLine();
        }
    }
}
InputMatrix(matrix);
