double[] arr = new double[10];

double MaxMinusMin(double[] array){
    double max = array[0], min = array[0];
    for(int i = 1; i < array.Length; i++){
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    return max - min;
}

Random rand = new Random();
double n = rand.Next(11, 1002);
for (int i = 0; i < 10; i++){
    n = rand.Next(11, 1002);
    while(n % 10 == 0) n = rand.Next(11, 1002);    
    arr[i] = n/10;
    Console.Write($"{arr[i]}" + " ");
}
Console.WriteLine();
Console.WriteLine(MaxMinusMin(arr));

