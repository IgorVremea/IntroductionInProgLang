int[] arr = new int[10];

int EvenCount(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Random rand = new Random();
for (int i = 0; i < 10; i++){
    arr[i] = rand.Next(1, 101);
    Console.WriteLine($"{arr[i] }");
}
Console.WriteLine(Count2090(arr));

