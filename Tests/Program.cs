int[] arr = new int[11];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++){
    arr[i] = rand.Next(100, 1000);
    Console.Write($"{arr[i]}" + " ");
}
for(int i = 0; i < arr.Length / 2; i++){
    int temp = arr[i];
    arr[i] = arr[arr.Length-i-1];
    arr[arr.Length-i-1] = temp;
}
Console.WriteLine();
for (int i = 0; i < arr.Length; i++){
    Console.Write($"{arr[i]}" + " ");
}
