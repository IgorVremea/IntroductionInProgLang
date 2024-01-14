int CountEven(int[] array){
    int sum =0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) sum++;
    }
    return sum;
}

int[] arr = new int[10];
Random rand = new Random();
for (int i = 0; i < 10; i++){
    arr[i] = rand.Next(100, 1000);
    Console.Write($"{arr[i]}" + " ");
}
Console.WriteLine();
Console.WriteLine("Четных чисел в мессиве: " + $"{CountEven(arr)}");
