int Factorial(int n){
    if(n==0) return 1;
        else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(2));
Console.WriteLine(Factorial(3));
Console.WriteLine(Factorial(4));
Console.WriteLine(Factorial(5));