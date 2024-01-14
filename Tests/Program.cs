// Инициализация массива
int[] arr = new int[10];

Random rand = new Random();
Console.Write("Было: ");
for (int i = 0; i < 10; i++){
    arr[i] = rand.Next(1, 101);
    Console.Write($"{arr[i]}" + ' ');
}
Console.WriteLine();

// Реализация рекурсии
void ShowRecursArr(int[] arr){
    if(arr.Length == 1) {
        Console.Write($"{arr[0]} ");
        return;
    }
    string str = string.Join(' ', arr);
    // Чойта не допер до более простого решения, если не использовать в функции дополнительный параметр...
    ShowRecursArr(Array.ConvertAll(str.Substring(str.IndexOf(' ') + 1).Split(' '), int.Parse));
    Console.Write($"{arr[0]}" + ' ');
}

// Проверка результата
Console.Write("Стало: ");
ShowRecursArr(arr);