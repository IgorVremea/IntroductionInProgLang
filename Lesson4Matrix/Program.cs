int[,] matrix = new int[3,4];
int count = 1;
for(int y = 0; y < matrix.GetLength(0); y++){
    for(int x = 0; x < matrix.GetLength(1); x++){
        matrix[y,x] = count++;
        Console.Write($"{matrix[y,x]} ");
    }
    Console.WriteLine();
}