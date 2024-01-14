void RecursNatural(int M, int N){
    if( N == 0 || M == 0) return;
    if( M == N ) {
        Console.Write($"{M} ");
        return;
    }
    if( N > M){
        RecursNatural(M, N-1);
        Console.Write($"{N} ");
    } else {
        RecursNatural(M-1, N);
        Console.Write($"{M} ");
    }
    
}

RecursNatural(20, -10);